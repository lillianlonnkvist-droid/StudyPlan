using UnityEngine;

public class OpenStudyLinks : MonoBehaviour
{
    // uppgifter
    public void OpenMathFormulas()
    {
        Application.OpenURL("https://www.skolverket.se/download/18.645f1c0e17821f1d15c5fa4/1625491482263/Formelblad%20Ma%202abc%202021.pdf");
    }

    public void OpenSwedishFormulas()
    {
        Application.OpenURL("https://www.lysator.liu.se/language/Languages/Swedish/Grammar.html");
    }

    public void OpenScienceFormulas()
    {
        Application.OpenURL("http://naturvetenskap.se/naturvetenskap/");
    }

    public void OpenHistoryFormulas()
    {
        Application.OpenURL("https://varldenshistoria.se/");
    }

    public void OpenTechnologyFormulas()
    {
        Application.OpenURL("https://www.mek.lth.se/fileadmin/mek/Education/FMEA05oFMEA15/formelsamling.pdf");
    }
    public void OpenEnglishFormulas()
    {
        Application.OpenURL("https://learnenglish.britishcouncil.org/grammar");
    }

    // uppgifter
    public void OpenMathTasks()
    {
        Application.OpenURL("https://vidma.se/");
    }

    public void OpenSwedishTasks()
    {
        Application.OpenURL("https://www.uu.se/nationella-prov/svenska-och-svenska-som-andrasprak/gymnasiet");
    }

    public void OpenScienceTasks()
    {
        Application.OpenURL("https://www.skolverket.se/download/18.5dfee44715d35a5cdfa8acb/1516017596133/Uppgifter_naturvetenskapPISA2000.pdf");
    }

    public void OpenHistoryTasks()
    {
        Application.OpenURL("https://www.superprof.se/blog/quiz-varldens-historia/");
    }

    public void OpenTechnologyTasks()
    {
        Application.OpenURL("https://www.sweclockers.com/artikel/31388-quiz-vad-kan-du-om-utdod-teknik");
    }

    public void OpenEnglishTasks()
    {
        Application.OpenURL("https://learnenglish.britishcouncil.org/");
    }
}