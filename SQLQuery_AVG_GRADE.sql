update Courses 
set AVG_GRADE = b.AvgGrade 
from 
(
select Course_Id, AVG(GRADE) As AvgGrade 
from Grades group by Course_Id
)b 
where b.COURSE_ID = Courses.ID
