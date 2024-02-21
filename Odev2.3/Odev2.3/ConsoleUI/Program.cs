using Odev2._3.Business.Concrete;
using Odev2._3.DataAccess.Abstract;
using Odev2._3.DataAccess.Concrete.Dapper;
using Odev2._3.Entities;

DCategoryDal dCategoryDal = new DCategoryDal();
EfCategoryDal efCategoryDal = new EfCategoryDal();
DCourseDal dCourseDal = new DCourseDal();
EfCourseDal efCourseDal = new EfCourseDal();
DInstructorDal dInstructorDal = new DInstructorDal();
EfInstructorDal efInstructorDal = new EfInstructorDal();

Console.WriteLine("-----Category---------------------------------------");

CategoryManager categoryManager = new CategoryManager(efCategoryDal);

Category category3 = new Category
{
    Id = 3,
    Name = "Frontend"
};

categoryManager.Add(category3);
List<Category> categoryList = categoryManager.GetAll(); 

foreach (Category category in categoryList)
{
    Console.WriteLine(category.Name);
}

Console.WriteLine("Eski hali: "+ categoryManager.GetById(2).Name);
categoryManager.Update(category3);
Console.WriteLine("Yeni hali: "+ categoryManager.GetById(2).Name);

categoryManager.Delete(1);

foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.Name);
}


Console.WriteLine("-----Course------------------------------------------");
CourseManager courseManager = new CourseManager(dCourseDal);

Course course4 = new Course
{
    Id = "12348",
    Name = "Phyton & Selenium Yazılım Geliştirici Yetiştirme Kampı",
    Price = 0,
    Description = "2 ayda bu işin profesyoneli olacaksın!"
};

courseManager.Add(course4);
List<Course> courseList = courseManager.GetAll();

foreach (Course course in courseList)
{
    Console.WriteLine(course.Name);
}


Console.WriteLine("Eski hali: " + courseManager.GetById("12348").Name);  //YİNE STRING SORUNU!
courseManager.Update(course4);
Console.WriteLine("Yeni hali: " + courseManager.GetById("12348").Name);

courseManager.Delete("12345");

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.Name);
}

Console.WriteLine("-----Instructor---------------------------------------");
InstructorManager instructorManager = new InstructorManager(efInstructorDal);

Instructor instructor3 = new Instructor
{
    Id = 3,
    Name = "Ekrem Paşa"
};

instructorManager.Add(instructor3);
List<Instructor> instructorList  = instructorManager.GetAll();

foreach (Instructor instructor in instructorList)
{
    Console.WriteLine(instructor.Name);
}


Console.WriteLine("Eski hali: " + instructorManager.GetById(1).Name);
instructorManager.Update(instructor3);
Console.WriteLine("Yeni hali: " + instructorManager.GetById(1).Name);

instructorManager.Delete(1);

foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine(instructor.Name);
}