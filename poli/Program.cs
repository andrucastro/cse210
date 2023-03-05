List<Shape> shapes = new List<Shape>();


Square s1 = new Square("Red", 3);
shapes.Add(s1);

Rectagle s2 = new Rectagle("Blue", 4, 5);
shapes.Add(s2);

Circle s3 = new Circle("Green", 6);
shapes.Add(s3);

 foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"Shape color is: {color}, Shape area is:{area}.");
        }

