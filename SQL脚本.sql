<<<<<<< HEAD
--sqlserver�ļ���׺.mdf��Ҫ�ļ�,log��־�ļ�,ndf��Ҫ�ļ�

--ʹ���Ǹ����ݿ�
use  JGWnameDB

--��
insert into  Students(stuName)
values('�ٺ�')
--������
insert into Students(stuName)
select ('СС') union
select('��̫��')
--��һ�����е������뵽��һ����
insert into  Students(stuName,ClassShcoolID)
select [name],id
from Test

--ɾ
delete  from  Students
where  stuname=('СС') or stuName=('�ٺ�') or stuName=('��̫��')
--�ָ����ű�
truncate  table  classinfos

--��
update  Students
set  stuName='������'
where stuName='����'

select @@VERSION--�鿴sqlserver�İ汾


--group by�����ѯ
--������Ӳ�ѯ

--count(1),��ʾα��,��Ϊ�ۺϺ�������ѯnull�����Բ���α������ѯÿһ��

--���ǳ����ڲ�ѯselect�ؼ���֮����У� ������ǾۺϺ�����
--��ôһ��Ҫ��ӵ�group by
--���꼶�ֳ�����ȷ��ÿ���꼶������
select studentsnianji,count(1) as '�꼶����' from  ShcoolInfos
group by studentsnianji
having count(1)>1  --��ʾΪɸѡ��������������1

--where ���ݼ���ɸѡ����group byǰʹ�ã������ں���
--having �����ɸѡ�Ĺؼ���
--order by  ����������������

--�õ�ÿ���꼶����������
select studentsnianji,max(classid) as '���' from ShcoolInfos
group by  StudentsNianji


--������
--������(inner join)��������:��������(left join)����������(right join)
select stuno,classshcoolid,stuname,classname1 from Students as a  --��Ҫ�������ӱ�����Ҫ��ʾ���У�selectѡ����
inner join  ClassInfos as b
on (a.ClassShcoolID=b.JGWshcoolID)
--�����ӣ����������ƥ�䣬ƥ��ĵ�����ʾ������ƥ�䲻������ʾ
---�������ӷ�ʽ
select top 4 stuno,classshcoolid,stuname from Students as a
inner join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID

select  top 4   a.stuno ,a.stuName,a.ClassShcoolID,b.className1
from  Students  as a ,ClassInfos as b
where a.ClassShcoolID=b.JGWshcoolID



--������ű����ӣ�û�����𣬶��ű�ʱ����inner join�ؼ��������ѯ

--������
--�����ӣ�����ߵı�Ϊ��׼ȥƥ���ұߵı����ƥ�䲻�����ݣ��ұ�Ϊnull
select  jgwshcoolid,classname1 from ClassInfos as a
left join  Students as b
on  a.JGWshcoolID=b.ClassShcoolID

--������
select stuno,stuName,ClassShcoolID,b.classname1 from  Students as a
right join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID
--ͨ�����ű���ͬ��������select a.* b.����   a.��ʾ������
--������ȫ������������������ͬ���������������

--ȥ�ظ���distinct�����е�������һ��

=======
--sqlserver�ļ���׺.mdf��Ҫ�ļ�,log��־�ļ�,ndf��Ҫ�ļ�

--ʹ���Ǹ����ݿ�
use  JGWnameDB

--��
insert into  Students(stuName)
values('�ٺ�')
--������
insert into Students(stuName)
select ('СС') union
select('��̫��')
--��һ�����е������뵽��һ����
insert into  Students(stuName,ClassShcoolID)
select [name],id
from Test

--ɾ
delete  from  Students
where  stuname=('СС') or stuName=('�ٺ�') or stuName=('��̫��')
--�ָ����ű�
truncate  table  classinfos

--��
update  Students
set  stuName='������'
where stuName='����'

select @@VERSION--�鿴sqlserver�İ汾


--group by�����ѯ
--������Ӳ�ѯ

--count(1),��ʾα��,��Ϊ�ۺϺ�������ѯnull�����Բ���α������ѯÿһ��

--���ǳ����ڲ�ѯselect�ؼ���֮����У� ������ǾۺϺ�����
--��ôһ��Ҫ��ӵ�group by
--���꼶�ֳ�����ȷ��ÿ���꼶������
select studentsnianji,count(1) as '�꼶����' from  ShcoolInfos
group by studentsnianji
having count(1)>1  --��ʾΪɸѡ��������������1

--where ���ݼ���ɸѡ����group byǰʹ�ã������ں���
--having �����ɸѡ�Ĺؼ���
--order by  ����������������

--�õ�ÿ���꼶����������
select studentsnianji,max(classid) as '���' from ShcoolInfos
group by  StudentsNianji


--������
--������(inner join)��������:��������(left join)����������(right join)
select stuno,classshcoolid,stuname,classname1 from Students as a  --��Ҫ�������ӱ�����Ҫ��ʾ���У�selectѡ����
inner join  ClassInfos as b
on (a.ClassShcoolID=b.JGWshcoolID)
--�����ӣ����������ƥ�䣬ƥ��ĵ�����ʾ������ƥ�䲻������ʾ
---�������ӷ�ʽ
select top 4 stuno,classshcoolid,stuname from Students as a
inner join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID

select  top 4   a.stuno ,a.stuName,a.ClassShcoolID,b.className1
from  Students  as a ,ClassInfos as b
where a.ClassShcoolID=b.JGWshcoolID



--������ű����ӣ�û�����𣬶��ű�ʱ����inner join�ؼ��������ѯ

--������
--�����ӣ�����ߵı�Ϊ��׼ȥƥ���ұߵı����ƥ�䲻�����ݣ��ұ�Ϊnull
select  jgwshcoolid,classname1 from ClassInfos as a
left join  Students as b
on  a.JGWshcoolID=b.ClassShcoolID

--������
select stuno,stuName,ClassShcoolID,b.classname1 from  Students as a
right join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID
--ͨ�����ű���ͬ��������select a.* b.����   a.��ʾ������
--������ȫ������������������ͬ���������������

--ȥ�ظ���distinct�����е�������һ��

>>>>>>> 45f0c71 (new)
--