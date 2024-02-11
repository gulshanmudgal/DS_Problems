#region PB_1 Driver Code
using Graph;

int[][] isConnected = new int[3][];
isConnected[0] = new int[3] { 1, 1, 0 };
isConnected[1] = new int[3] { 1, 1, 0 };
isConnected[2] = new int[3] { 0, 0, 1 };

int count = PB_1.FindCircleNum(isConnected);
Console.WriteLine(count);
#endregion

#region PB_2 Driver Code
char[][] grid = new char[4][]
{
    new char[5]{ '1','1','1','1','0' },
    new char[5]{ '1','1','0','1','0' },
    new char[5]{ '1','1','0','0','0' },
    new char[5]{ '1','1','0','0','0' },
};

// int islandCount = PB_2.NumIslands(grid);
// Console.WriteLine(islandCount);
#endregion


#region PB_5 Driver Code
int[][] mat = new int[3][]
{
    new int[3] { 0,0,0 },
    new int[3] { 0,1,0 },
    new int[3] { 0,0,0 }
};
var dist = PB_5.UpdateMatrix(mat);
for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.WriteLine(dist[i][j]);
    }
}
#endregion