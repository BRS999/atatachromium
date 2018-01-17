using Atata;
using AtataUITests1;

namespace AtataUITests1
{
    using _ = HomePage;
    internal class HomePage : AppPage<_>
    {
        [FindById(TermCase.Lower)]
        public TextInput<_> TextBox { get; set; }
    }
}