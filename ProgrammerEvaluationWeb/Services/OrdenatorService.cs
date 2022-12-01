namespace ProgrammerEvaluationWeb.Services
{
    public class OrdenatorService
    {
        public static int[] Order(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        var temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }

            return vector;
        }
    }
}
