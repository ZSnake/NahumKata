using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_one_and_four
    {
        private static StringCalculator _stringCalculator;
        private static int _return;

        private Establish context = () => { _stringCalculator = new StringCalculator(); };

        private Because of = () => { _return = _stringCalculator.Add("1,4"); };

        private It should_return_five = () => { _return.ShouldBeLike(5); };
    }
}