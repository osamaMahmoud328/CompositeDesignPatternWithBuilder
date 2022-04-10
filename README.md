# CompositeDesignPatternWithBuilder

Apply Composite Design Pattern With Builder Approach.

# Project Structure:
Two projects to clearify the idea:
 - First project[Drawing] (Drawing composite shape to create a tree with nodes of shapes like Pictures , ...etc
    - DrawingElement.cs: the Component of composite pattern, this is the base component element for drawing.
    - PrimitiveElement.cs: the Leaf of composite patternt, this is the simplest shape that has no child.
    - CompositeElement.cs: the composite of composite pattern, this a complex shape that has a child or more than one.
    - DrawingBuilder.cs: our builder pattern to make it easy to deal with our service that creates shapes, and also to encapsulate and abstract our modules.
    - 
 - Seconed project[FileSystem] (simulate directories tree structure to know the size of any file or a whole directory on our root folder.
    - FileSystemItem.cs: the Component of composite pattern, this is the base component element.
    - FileItem.cs: the Leaf of composite patternt, this is a simulation of any file.
    - FileDirectory.cs: the composite of composite pattern, this is a simulation of any directory/folder that contains files or other directories/folder.
    - FileSystemBuilder.cs: our builder pattern to make it easy to deal with our service that creates files or folders, and also to encapsulate and abstract our modules.
