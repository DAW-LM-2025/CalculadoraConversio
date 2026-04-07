namespace Conversors.Abstract;

public interface IPersistencia
{
    public const string PathXML = "persona.xml";
    public const string PathJSON = "persona.json";
    void PersisteixAdisc(string objecteSerialitzat, string path);

    /// <summary>
    /// Llegeix un fitxer i retorna el seu contingut com a string
    /// </summary>
    /// <param name="path">El camí del fitxer a llegir</param>
    /// <returns>El contingut del fitxer com a string</returns>
    string LlegeixDisc(string path);
}


