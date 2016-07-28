
namespace MainProject
{
    public class Test
#if !NETSTANDARD1_5
                : DependencyProject.Bla
#endif
    {

    }
}