using CompositeDesignPattern;
using CompositeDesignPattern.Drawing;
using CompositeDesignPattern.FileSystem;

static void DrawingBuilder()
{
    DrawingBuilder drwaingBuilder = new("Picture");
    drwaingBuilder.AddPrimitiveElement("Red Line");
    drwaingBuilder.AddPrimitiveElement("Blue Line");
    drwaingBuilder.AddPrimitiveElement("Green Line");

    drwaingBuilder.AddCompositeShape("White Circle");
    drwaingBuilder.AddPrimitiveElement("White Line");
    drwaingBuilder.AddPrimitiveElement("White Fill");

    drwaingBuilder.SetCurrentShape("Picture");
    drwaingBuilder.AddCompositeShape("Blue Square");
    drwaingBuilder.AddPrimitiveElement("Blue Line");
    drwaingBuilder.AddPrimitiveElement("Blue Fill");

    drwaingBuilder.SetCurrentShape("Blue Square");
    drwaingBuilder.AddCompositeShape("New Circle");
    drwaingBuilder.AddPrimitiveElement("New Circle Line");

    drwaingBuilder.RootShape.Display(1);
}
static void FileSystemBuilder()
{
    FileSystemBuilder fileSystemBuilder = new("Courses");
    fileSystemBuilder.AddFile("Ux File", 1000);
    fileSystemBuilder.AddFile("Ui File", 1000);

    fileSystemBuilder.AddDirectory("DotNet Course");
    fileSystemBuilder.AddFile("DotNet Intro.pdf", 2000);
    fileSystemBuilder.AddFile("DotNet Basics.pdf", 2000);
    fileSystemBuilder.AddFile("DotNet Advance.pdf", 2000);

    fileSystemBuilder.SetCurrentDirectory("Courses");
    fileSystemBuilder.AddDirectory("Python Course");
    fileSystemBuilder.AddFile("Python Advance.pdf", 2000);
    fileSystemBuilder.AddFile("Python Basics.pdf", 2000);
    fileSystemBuilder.AddFile("Python Advance.pdf", 2000);

    fileSystemBuilder.SetCurrentDirectory("Python Course");
    fileSystemBuilder.AddDirectory("Python Videos");
    fileSystemBuilder.AddFile("Python-Intro.mp4", 1000);
    fileSystemBuilder.AddFile("Python-Intro.mp4", 1000);

    Console.WriteLine($"Root Directory Courses is : {fileSystemBuilder.RootDirectory.GetSizeInByte()} Byte ");

    Console.WriteLine($"Directory DotNet Course is : {fileSystemBuilder.RootDirectory.FileSystemItems.SingleOrDefault(course => course.FileName== "DotNet Course").GetSizeInByte()} Byte ");

    Console.WriteLine($"Directory DotNet Course is : {fileSystemBuilder.RootDirectory.FileSystemItems.SingleOrDefault(course => course.FileName == "Python Course").GetSizeInByte()} Byte ");
}

static void Drawing()
{
    CompositeElement picture = new CompositeElement("Picture");
    picture.AddShape(new PrimitiveElement("Red Line"));
    picture.AddShape(new PrimitiveElement("Blue Line"));
    picture.AddShape(new PrimitiveElement("Green Line"));

    CompositeElement circle = new CompositeElement("White Circle");
    circle.AddShape(new PrimitiveElement("White Line"));
    circle.AddShape(new PrimitiveElement("White Fill"));

    CompositeElement square = new CompositeElement("blue square");
    square.AddShape(new PrimitiveElement("Blue Line"));
    square.AddShape(new PrimitiveElement("Blue Fill"));

    picture.AddShape(circle);
    picture.AddShape(square);

    picture.Display(1);
    Console.WriteLine("====================");

    circle.Display(1);
    Console.WriteLine("====================");

    square.Display(1);
}

static void FileSystem()
{
    FileDirectory rootDirectory = new("Courses");
    rootDirectory.AddItem(new FileItem("Ux File", 1000));
    rootDirectory.AddItem(new FileItem("Ui File", 1000));

    FileDirectory dotNetCourse = new("DotNet Course");
    dotNetCourse.AddItem(new FileItem("DotNet Intro.pdf", 2000));
    dotNetCourse.AddItem(new FileItem("DotNet Basics.pdf", 2000));
    dotNetCourse.AddItem(new FileItem("DotNet Advance.pdf", 2000));

    FileDirectory pythonCourse = new("Python Course");
    pythonCourse.AddItem(new FileItem("Python Intro.pdf", 2000));
    pythonCourse.AddItem(new FileItem("Python Basics.pdf", 2000));
    pythonCourse.AddItem(new FileItem("Python Advance.pdf", 2000));

    FileDirectory pythonVideos = new("Python Videos");
    pythonVideos.AddItem(new FileItem("Python-Intro.mp4", 1000));
    pythonVideos.AddItem(new FileItem("Python-Basics.mp4", 1000));

    pythonCourse.AddItem(pythonVideos);

    rootDirectory.AddItem(dotNetCourse);
    rootDirectory.AddItem(pythonCourse);

    Console.WriteLine($"Root Directory Courses is : {rootDirectory.GetSizeInByte()} Byte ");

    Console.WriteLine($"Directory DotNet Course is : {dotNetCourse.GetSizeInByte()} Byte ");

    Console.WriteLine($"Directory Python Course is : {pythonCourse.GetSizeInByte()} Byte ");
}


//Drawing();
//Console.WriteLine("====================================");
//Console.WriteLine("File System :");
//FileSystem();
//DrawingBuilder();
FileSystemBuilder();






