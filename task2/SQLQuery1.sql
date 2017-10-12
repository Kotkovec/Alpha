select boss.name
from   employee boss, employee worker
where  worker.id = boss.chief_id
and (select AVG(salary)*2 from employee worker) < boss.salary;
