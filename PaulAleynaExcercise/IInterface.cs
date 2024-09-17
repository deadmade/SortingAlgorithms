namespace PaulAleynaExcercise;

/* Interfaces:
    Interfaces werden oft benutzt, um als Bauplan zu funktionieren. Das heißt, das ich beispiels weiße ein Interface implementiere 
    → Also welche Methoden zur Verfügung stehen, und diese dann bereits von anderen Leuten verwendet werden können, auch wenn sie noch nicht fertig implementiert sind. 
   Es ist auch möglich unterschiedliche Implementierungen eines Interfaces zu tauschen, um flexibler zu sein. (Eventuell unterschiedliche Berechnung pro Land)
*/
   
public interface IInterface
{
    public int[] Sort(int[] arrayToSort);
    public string GetName();
}