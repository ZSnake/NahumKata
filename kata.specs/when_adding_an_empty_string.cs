using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_an_empty_string
    {
        Establish context = () =>
        {
            _stringCalculator = new StringCalculator();
        };
        private Because of = () =>
        {
            _result = _stringCalculator.Add("");
        };

        private It should_return_0 = () =>
        {
            _result.ShouldBeLike(0);
        };

        private static StringCalculator _stringCalculator;
        private static int _result;
    }
}