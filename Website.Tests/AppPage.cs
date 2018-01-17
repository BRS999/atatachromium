using Atata;

namespace AtataUITests1
{
    [WaitForDocumentReadyState]
    public abstract class AppPage<TOwner> : Page<TOwner>
        where TOwner : AppPage<TOwner>
    {

    }
}

