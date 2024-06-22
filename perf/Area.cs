
public static class TotalArea 
{
    public static float Virt(List<IShape> shapes) {
        float totalArea = 0.0f;
        foreach (var shape in shapes ) {
            totalArea += shape.Area();
        }
        return totalArea;
    }   


    public static float Inlined(Shape[] shapes) {
        float totalArea = 0f;       
        foreach (var shape in shapes) {
            totalArea += shape.Area();    
        } 
        return totalArea;
    }

    public static float InlinedVectorized(Shape[] shapes) {        
        
        return 0.0f;
    }    

}