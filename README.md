# RepositoryPattern.Simple
Repository Pattern Simple\
This package was written in .NET 5.0\
There are 2 base classes and 2 interface
* GenericRepo
* UnitOfWork
* IGenericRepo
* IUnitOfWork
## Example
This a **ASP NET CORE WEB API** project
### Repositories
I organized the file like the image below

![Organized](/assets/images/organized.png)

I conntected with my database and generated 3 classes in **Models directory** based on my databse

![Models Directory](/assets/images/models-directory.png)

- Course
- Enrollment
- AppContext

We'll create a directory with name is **Repositories**\
We'll create a classes named **CoursesRepo** implemented from **GenericRepo** based class\
The **EnrollmentsRepo** class is same for the **CoursesRepo** class

![Implemented GenericRepo](/assets/images/course-implemented-genericrepo.png)

Default GenericRepo includes methods:
* ```Get```
* ```GetAsync```
* ```GetAll```
* ```GetAllAsync```
* ```Add```
* ```AddAsync```
* ```Update```
* ```UpdateAsync```
* ```Remove```
* ```RemoveAsync```

If you want to add or modify the above methods, you can ```override``` them.

### UnitOfWork
We create a interface ```ICourseUnitOfWork``` inherit from ```IUnitOfWork``` interface

![Implemented Unit Of Work](/assets/images/courseunit-implemented-uni.png)

If you want to add or modify the above methods, you can ```override``` them.

### Remember to declare the services in the startup.cs file

![Implemented GenericRepo](/assets/images/startup-unit-repo.png)

### Usage

![Usage](/assets/images/usage-unit.png)
