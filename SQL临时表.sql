<<<<<<< HEAD
--��ʱ����ʱ���ڴ��й� c#��datatable��ʱ�����������ʱ����ʱ�����
--��ͼ����������ļ�¼���Դ���

--���ݿ���ʱ��ȫ����ʱ��##����ͨ��ʱ��#
--������ű����ʱ��#


create table test2
(id  int identity(1,1),
name varchar(10)  not null
)
insert into  test2 (name)
values('����')


--��һ���Զ���һ����ʱ��ֻ���ڻ㻰����ִ�У��������ڴ���
--��һ��drop table #test2���ڶ��־��ǹرջỰ����
--��ʱ��ֻ���ڵ�ǰ�Ự����
create table #test2--ֻ�������ڴ�
(id  int identity(1,1),
name varchar(10)  not null
)
insert into #test2
values('����')
select *from #test2

--�ڶ��ֿ�¡������ʱ����ʵ��
select [stuNo], [ClassShcoolID], [stuName], [sex]
 into students2  from Students --��ʵ��

 select [stuNo], [ClassShcoolID], [stuName], [sex]
 into #test3  from Students--��ʱ��

 select * from #test3

=======
--��ʱ����ʱ���ڴ��й� c#��datatable��ʱ�����������ʱ����ʱ�����
--��ͼ����������ļ�¼���Դ���

--���ݿ���ʱ��ȫ����ʱ��##����ͨ��ʱ��#
--������ű����ʱ��#


create table test2
(id  int identity(1,1),
name varchar(10)  not null
)
insert into  test2 (name)
values('����')


--��һ���Զ���һ����ʱ��ֻ���ڻ㻰����ִ�У��������ڴ���
--��һ��drop table #test2���ڶ��־��ǹرջỰ����
--��ʱ��ֻ���ڵ�ǰ�Ự����
create table #test2--ֻ�������ڴ�
(id  int identity(1,1),
name varchar(10)  not null
)
insert into #test2
values('����')
select *from #test2

--�ڶ��ֿ�¡������ʱ����ʵ��
select [stuNo], [ClassShcoolID], [stuName], [sex]
 into students2  from Students --��ʵ��

 select [stuNo], [ClassShcoolID], [stuName], [sex]
 into #test3  from Students--��ʱ��

 select * from #test3

>>>>>>> 45f0c71 (new)
 --ȫ�ֵ���ʱ���������ڴ��֣����������Ĵ��ڹر�ʱ������ʧ