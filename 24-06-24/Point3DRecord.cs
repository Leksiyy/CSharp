namespace _24_06_24;

public record Point3DRecord(int X, int Y, int Z)
{
    public int X = X;

    public int Y = Y;

    public int Z = Z;
}

public static class Point3DRecordExtensions
{
    public static int Distance(this Point3DRecord point1, Point3DRecord point2)
    {
        return point1.X + point1.Y + point1.Z - point2.X + point2.Y + point2.Z;
    }
    
    public static List<Point3DRecord>? MaxDistance(this List<Point3DRecord> list)
    {
        List<Point3DRecord> result = new List<Point3DRecord>();

        Point3DRecord temp1 = new Point3DRecord(0, 0, 0);
        Point3DRecord temp2 = new Point3DRecord(0, 0, 0);
        
        result.Add(temp1);
        result.Add(temp2);
            
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i+1; j < list.Count; j++)
            {
                if (list[i].X + list[i].Y + list[i].Z - list[j].X + list[j].Y + list[j].Z > result[1].X + result[1].Y + result[1].Z - result[0].X + result[0].Y + result[0].Z)
                {
                    result[0] = list[i];
                    result[1] = list[j];
                }
            }
        }

        if (result[0] == temp1 && result[1] == temp2) return null;
        
        return result;
    }
}
