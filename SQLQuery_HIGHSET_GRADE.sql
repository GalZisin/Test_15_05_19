update Courses 
set HIGHSET_GRADE = b.MaxGrade 
from 
(
select Course_Id, Max(GRADE) As MaxGrade 
from Grades group by Course_Id
)b 
where b.COURSE_ID = Courses.ID
