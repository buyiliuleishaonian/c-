use ѧ��ѧϰϵͳ����DB

insert into classinfos(ClassId,ClassName) values(1,'���1��')
insert into classinfos(ClassId,ClassName) values(2,'���2��')
insert into classinfos(ClassId,ClassName) values(3,'�����1��')
insert into classinfos(ClassId,ClassName) values(4,'�����2��')
insert into classinfos(ClassId,ClassName) values(5,'����1��')
insert into classinfos(ClassId,ClassName) values(6,'����2��')

insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('��С��','��','1989-08-07',22,120223198908071111,'0004018766','022-22222222','������Ͽ�����|��Ԣ5-5-102',1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('��С��','Ů','1989-05-06',22,120223198905062426,'0006394426','022-33333333','����кӱ���������58��',2)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('��С��','��','1990-02-07',21,120223199002078915,'0006073516','022-44444444','����к��������ֹ����·79��',4)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('��Сǿ','Ů','1987-05-12',24,130223198705125167,'0006254540','022-55555555',default,2)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('��С��','Ů','1986-05-08',25,130223198605081528,'0006403803','022-66666666','�ӱ���ˮ·����69��',1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('������','��','1987-07-18',24,130223198707182235,'0006404372','022-77777777',default,1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('������','��','1988-09-28',24,130223198909282235,'0006092947','022-88888888','�ӱ������з绪��12��',3)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('����','��','1987-01-18',24,130223198701182257,'0006294564','022-99999999','�ӱ���̨���Ҹ�·5��',1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('������','Ů','1987-06-15',24,130223198706152211,'0006092450','022-11111111',default,3)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('������','Ů','1989-08-19',24,130223198908192235,'0006069457','022-11111222',default,4)

insert into scorelistinfos (id,CSharp,SQLserver�ɼ�)values(100000,60,78)
insert into scorelistinfos (id,CSharp,sqlserver�ɼ�)values(100001,55,88)
insert into scorelistinfos (id,CSharp,sqlserver�ɼ�)values(100002,90,58)
insert into scorelistinfos (id,CSharp,sqlserver�ɼ�)values(100003,88,75)

insert into scorelistinfos (id,CSharp,sqlserver�ɼ�)values(100004,62,88)
insert into scorelistinfos (id,CSharp,sqlserver�ɼ�)values(100006,52,80)
insert into scorelistinfos (id,CSharp,sqlserver�ɼ�)values(100007,91,66)
insert into scorelistinfos (id,CSharp,sqlserver�ɼ�)values(100009,78,35)

insert into Admins (password,AdminName) values(123456,'������')
insert into Admins (password,AdminName) values(123456,'������')


select *from StudentsInfos
select*from ScoreListInfos
select*from ClassInfos
select*from AttendanceInfos
select*from admins