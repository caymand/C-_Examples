// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

Random rng = new Random(42);
float TotalAreaVirt(List<IShape> shapes) {
    float totalArea = 0.0f;
    foreach (var shape in shapes ) {
        totalArea += shape.Area();
    }
    return totalArea;
}

float TotalArea(Shape[] shapes) {
    float totalArea = 0f;       
    foreach (var shape in shapes) {
        totalArea += shape.Area();    
    } 
    return totalArea;
}

Shape CreateShape(ShapeType shapeType) 
{
    return new Shape {
        Width = 0.5f,
        Height = 0.5f,
        Type = shapeType
    };
}

IShape CreateShapeVirt(ShapeType ShapeType) {
    switch (ShapeType) {
        case ShapeType.Square :
            return new Square(0.5f);        
        case ShapeType.Rectangle :
            return new Rectangle(0.5f,0.5f);
        case ShapeType.Triangle:
            return new Triangle(0.5f,0.5f);
        case ShapeType.Circle:
            return new Circle(0.5f);        
        default :
            return new Square(0.5f); 
    }
}

List<IShape> shapesVirt = new List<IShape>();
Shape[] shapes = new Shape[100000];
for (int i = 0; i < 100000; i++) {    
    ShapeType ShapeType = (ShapeType)rng.Next(0,3);
    shapesVirt.Add(CreateShapeVirt(ShapeType));
    shapes[i] = CreateShape(ShapeType);
} 
void BenchVirt(int n_runs) {
    Stopwatch sw = new Stopwatch();
    sw.Start();
    for (int i = 0; i < n_runs; i++) {
        TotalAreaVirt(shapesVirt);
    }
    TimeSpan ts = sw.Elapsed;    
    Console.WriteLine($"Virtual. Time for {n_runs}: {ts.Milliseconds}");
}
void BenchInlined(int n_runs) {
    Stopwatch sw = new Stopwatch();
    sw.Start();
    for (int i = 0; i < n_runs; i++) {
        TotalArea(shapes);
    }
    TimeSpan ts = sw.Elapsed;    
    Console.WriteLine($"Inlined. Time for {n_runs}: {ts.Milliseconds}");
}

BenchVirt(1);
BenchVirt(100);
BenchInlined(1);
BenchInlined(100);
