using System.Globalization;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Luna.Desktop;

public class SpeechService
{
    public static SpeechService Instance { get; } = new();

    private SpeechRecognitionEngine? _wake;
    private SpeechRecognitionEngine? _dictation;
    private readonly SpeechSynthesizer _tts = new();

    private SpeechService()
    {
        try { _tts.SetOutputToDefaultAudioDevice(); } catch { }
    }

    public void StartWakeWordListening(Action onWake)
    {
        try
        {
            var recInfo = GetRecognizer("de");
            _wake = new SpeechRecognitionEngine(recInfo?.Culture ?? CultureInfo.CurrentUICulture);

            var choices = new Choices(new[] { "luna", "hey luna", "ok luna" });
            var gb = new GrammarBuilder(choices) { Culture = _wake.RecognizerInfo.Culture };
            var grammar = new Grammar(gb);

            _wake.LoadGrammar(grammar);
            _wake.SpeechRecognized += (_, e) =>
            {
                if (e.Result.Confidence >= 0.6) onWake();
            };
            _wake.SetInputToDefaultAudioDevice();
            _wake.RecognizeAsync(RecognizeMode.Multiple);
        }
        catch
        {
            // evtl. fehlende Sprachpakete
        }
    }

    public void StartDictation(Action<string> onHypothesis, Action<string> onCompleted)
    {
        try
        {
            var recInfo = GetRecognizer("de");
            _dictation = new SpeechRecognitionEngine(recInfo?.Culture ?? CultureInfo.CurrentUICulture);
            _dictation.LoadGrammar(new DictationGrammar());
            _dictation.SpeechHypothesized += (_, e) => onHypothesis(e.Result.Text);

            string final = string.Empty;
            _dictation.SpeechRecognized += (_, e) => final = e.Result.Text;
            _dictation.RecognizeCompleted += (_, _) => onCompleted(final);

            _dictation.SetInputToDefaultAudioDevice();
            _dictation.RecognizeAsync(RecognizeMode.Single);
        }
        catch
        {
            onCompleted(string.Empty);
        }
    }

    public void Speak(string text)
    {
        try { _tts.SpeakAsync(text); } catch { }
    }

    private static RecognizerInfo? GetRecognizer(string startsWith)
    {
        return SpeechRecognitionEngine.InstalledRecognizers()
            .FirstOrDefault(r => r.Culture.Name.StartsWith(startsWith, StringComparison.OrdinalIgnoreCase));
    }
}
