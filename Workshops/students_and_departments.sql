select
    d.Name as [Department],
    count(s.ID) as [Total Students],
	count(case when s.Gender ='M' then 1 end) as Male,
	count(case when s.Gender ='F' then 1 end) as Female
from
    DEPARTMENT d 
    left join Student s ON d.ID = s.DEPT_ID
group by
    d.Name
order by
    count(s.ID) desc, 
    d.Name desc