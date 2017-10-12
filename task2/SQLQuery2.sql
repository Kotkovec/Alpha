select distinct worker.name
from employee worker 
where worker.department_id = '2'
group by name
having count(worker.name) = 2;


