update Courses 
set NUM_OF_STUDENTS = b.Counter 
from 
(
select Course_Id, Count(*) As Counter 
from Grades group by Course_Id
) b 
where b.COURSE_ID = Courses.ID