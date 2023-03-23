using Demo_ConsoleAndEFC;

using (SchoolContext db = new SchoolContext())
{
    // We now have an open connection to our Database!

    // Create a new student
    Student studentToAdd = new Student();
    studentToAdd.Name = "Brandy";

    // Add to the database
    db.Students.Add(studentToAdd);

    // Save changes made to database
    db.SaveChanges();

} // Connection closes