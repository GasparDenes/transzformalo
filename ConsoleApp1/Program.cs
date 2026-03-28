namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int[] x_pos=new int[4];
        int[] y_pos=new int[4];
        int[] new_x_pos=new int[4];
        int[] new_y_pos=new int[4];
        for (int i = 0; i < 4; i++)
        {
            System.Console.Write($"Kérem a(z) {i+1}. pont koordinátáit: ");
            string[] egysor=Console.ReadLine().Split(',');
            x_pos[i]=int.Parse(egysor[0]);
            y_pos[i]=int.Parse(egysor[1]);
            new_x_pos[i]=x_pos[i];
            new_y_pos[i]=-y_pos[i];
        }
        for (int i = 0; i < 4; i++)
        {
            System.Console.WriteLine($"A(z) {i+1}. pont tükrözött képe: {new_x_pos[i]}, {new_y_pos[i]}");
        }
    }
}
