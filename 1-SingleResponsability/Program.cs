using SingleResponsability;

StudentRepository studentRepository = new();
ExportHandler exportHandler = new();
exportHandler.ExportStudent(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");