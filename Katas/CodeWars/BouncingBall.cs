namespace Katas.CodeWars
{
    public class BouncingBall
    {

        public static int bouncingBall(double height, double bounce, double window)
        {

            if (bounce >= 1 || bounce <= 0 || height <= 0)
            {
                return -1;
            }
            int ballWasSeenTimes = 0;

            do
            {
                ballWasSeenTimes += BouncingBall.Bounce(height, window)*2;
                height = height*bounce;
            } while (height > window);

            // your code
            return ballWasSeenTimes-1;
        }

        private static int Bounce(double height, double window)
        {
            return height > window ? 1 : 0;
        }
    }
}