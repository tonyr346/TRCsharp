namespace trINV;
using Inventor;
class Program
{
    static void Main(string[] args)
    {
          // Initialize Inventor application
        Application inventorApp = (Application)Activator.CreateInstance(Type.GetTypeFromProgID("Inventor.Application"));

        // Create a new part document
        Document doc = inventorApp.Documents.Add(DocumentTypeEnum.kPartDocumentObject, inventorApp.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject));
        PartDocument partDoc = (PartDocument)doc;

        // Access the part component
        PartComponentDefinition partCompDef = partDoc.ComponentDefinition;

        // Create a new sketch
        PlanarSketch sketch = partCompDef.Sketches.Add(partCompDef.WorkPlanes[3]);

        // Draw a rectangle
        sketch.SketchLines.AddByTwoPoints(sketch.ModelToSketchSpace(new Point2d(0, 0)), sketch.ModelToSketchSpace(new Point2d(10, 10)));

        // Finish the sketch
        sketch.SketchLines.AddByTwoPoints(sketch.ModelToSketchSpace(new Point2d(0, 0)), sketch.ModelToSketchSpace(new Point2d(0, 10)));

        // Save the document
        doc.SaveAs(@"/workspaces/TRCsharp/Programs/24_TRSept/INV24/trINV", false);
    }
}
