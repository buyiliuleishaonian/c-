<<<<<<< HEAD
use JGWnameDB

--ÿһ�β�ѯ�����ǲ�������� 
--���Ų�ѯ�Ľ���������ű��ģʽ��ʾ

--c# �����û� ����
--��ҵ����棿
--����վ����winform���õ�������
--�� as ����
--�� �ո�  ����
--����=��

--���� ��������Ĭ���������
--order by <���������>
select * from Students
where   sex='��'
order by  stuno
--order by  ������������ѧ�����飬����ɸѡ�����������,asc����desc����
--asc �����С����
--desc ����Ӵ�С
--����
select  stuno from Students
order by  stuno asc
--����
select  stuno from Students
order by  stuno desc	

--��ѯ�﷨
--select  ����
--from  ����
--where ��������
--order  by   ����[asc��desc]     
select  ClassShcoolID,stuName
from Students
where  sex='��'
order by   stuNo

--�ַ����ϲ��У��ֶη����ͣ�  �ַ���+�ַ���=ƴ�ӣ� ����+����=����
--convertת����cast�� convert(varchar,ClassShcoolID),cast(stuno as varchar) 
select  convert(nvarchar,classshcoolid)+stuName
from Students

--�ַ����ղ���null,ʲô��û�У������=null�����󴴽�֮��û�и�ֵ
--�ж����ݶο� where  creattime is null


--���ƹ̶�����
--1�����ƹ̶����У�top 1
select top 4 stuNo from Students

--2�����ٷֱ���ʾ���� top 2 percent
select top 80  percent ClassShcoolID from Students


--�ַ��������ļ��ຯ��
--charindex��var1��var2��var3����Ѱ��һ��ָ���ַ�������һ���ַ����п�ʼ��λ�ã�û�����ִ�Сд
--����1����ѯ�Ĳ���������2�����������ַ���������3�������ؿ�ʼ�ң����ݿ�������ַ��������ĳ����Ǵ�0��ʼ��
select stuname from students where stuno=1004
select CHARINDEX('��','������',1) stuname
from Students

--�ַ������ȣ�len��'�ַ���'��,���ش��ݸ������ַ�������
select stuname  from Students  where len(stuname)>=3

--upper�����ַ�����СдתΪ��д upper('�ַ���')
select upper('wenqiaocui')

--ltrim:�����ߵĿո� ltrim('�ַ���')
select LTRIM('  ����')

--rtrim������ַ����ұߵĿո�  rtrim��'�ַ���'��

--right:���ַ����ұ߷���ָ����Ŀ���ַ�  right��'�ַ���',1��

--replace���滻һ���ַ����е��ַ� replace('�ַ���','var1','var2')��var1��ʾΪ��Ҫ�滻���ַ���var2��ʾ�滻��ֵ
select  replace('������������','��������','�¸��԰�')

--stuff����һ���ַ����У�ɾ��ָ��������ָ�����ȣ����Ҳ���һ���µ��ַ�����stuff��'�ַ���1',2��������,3��������,'�ַ���2'��
select  stuff('����',2,1,'��˧')


--���ں���
--getdate��ȡ�õ�ǰʱ�� select getdate���������ؽ�������
select getdate()

--dateadd����ָ�����ּӵ����ڵ�ָ������ select  dateadd(mm,4,'01/01/2009'),����ֵ5/1/2009

--datediff����������֮���ָ�����ڲ��ֵļ�� select datediff��mm,'01/01/2001','05/01/2001'��������4

--datename��������ָ�����ڲ��ֵ��ַ�����ʽ select datename��mm,'01/01/2000'�� ���� ����������saturday

--datepart��������ָ�����ڲ��ֵ�������ʽ select datepart��day,'01/15/2000'�� ����15

--��õ�ǰ���ڵĸ��ָ�ʽ,��convertת������ת���ַ�����ʽ��֮��ѡ�����ָ�ʽ������ٶ�selserver��convertת�����ڸ�ʽ
select CONVERT(varchar,GETDATE(),111)

select (DATEADD (day,1,getdate()))
--c# yy�� MM��  dd��  hhСʱ   mm��  ss��
--sql  yy��  mm��   dd��  m��   


--��ѧ����
--rand �����ش�0��1�����floatֵ�� select rand����

--abs��ȡ��ֵ���ʽ�ľ���ֵ select abs����ѧ���ʽ��

--geiling��ȡ���ڻ����ָ����ֵ�����ʽ����С���� select  getling��43.5��  ����ֵ44

--floor��ȡС�ڻ����ָ����ֵ�����ʽ��������� select floor��43.5�� ����ֵ43

--power��ȡ��ֵ���ʽ����ֵ select power��5��2�� ����ֵ25  5^2

--rouno:����ֵ���ʽ��������Ϊָ������ select rouno��43.543��1�� ����ָ43.5

--sigh: ������������ֵ+1�����ڸ�������ֵ-1������0����0�� select sigh��-43�� ����ֵ-44

--sqrt;ȡ������ʽ��ƽ���� select sqrt��9�� ����ֵ3



--ϵͳ����
--convert������ת����������convert ��varchar,12334��

--current_use: ���ص�ǰ�û�����select current_use

--datalength����������ָ�����ʽ���ֽ�����select datalength

--host_name:���ص�ǰ�����������ļ�������֣�select host_name()

--system_user:���ص�ǰ��������û����ƣ�select system_user

--user_name: �Ӹ������û�id�����û�����select user_name(1)�� ����ֵ���������ݿ��з���'db0'



--��ѯ���ú���
--LIKE,BETWEEN,IN����ģ����ѯ
--ʹ�þۺϺ���ͳ�ƺͻ��ܺ���

--ģ����ѯ,��֪���������Ϣ��ֻ֪��һ����
--ģ����ѯlike,����ƥ���ν�������ѯ����Ϣ������ѡ��ɸѡ��������֪���������Ϣ��ֻ֪��һ����
--like
--ͨ���1��_����ʾһ���ַ���A LIKE '��_'  ��ʾ ��cs������  ��Щ����
--ͨ���2��%����ʾ���ⳤ�ȣ�B LIKE	'��_',��ʾֻҪ�����ŵ����ݶ���ȡ����
--ͨ���3��[]:��ʾ�涨�ĳ��ȷ�Χ��C LIKE '��[1-2]',��ʾ�ŵĺ������2��3���ַ�������ȫ����ȡ������
--ͨ���4��[^]���������ŷ�Χ���������ȡ���� ��D LIKE '��[^1-2]' ,
select *from  Students
where stuName like '��%'  

--in ����/not in ������
select*from Students 
where stuNo in (1001,1002,1003)
--truncate table students�ָ������ʼ
truncate table students
--��ҳ
select top 3* from  Students
where stuNo in (1,2,3)

select top 3*from Students
where stuno in(4,5,6)

select  top 3*from Students 
where stuNo in(7,8,9)

--ǰ���У�Ϊһҳ
select top 3 * from Students

--������Ϊһҳ
select top 3* from Students
where  stuNo not in (select top 3 *from Students)


--between �Ƽ�ʹ��
--���ֺ����ڵ�ɸѡ
--����������С����Ĳ��ң�Ч�����bettwwn ��С�������
select * from Students
where stuno between 1 and 3



--�ۺϺ������� ���ֵmax ��Сֵ min �ܺ� sum, ƽ��avg ֻ���������� ͳ�Ƽ�¼count������ͳ���ַ��������ڣ�null������ͳ�ƣ�һ��������ͳ��
select  max(qian) as zuidazhi from Students
select min(qian) from Students
select  avg(qian) from Students
select sum(qian)  from Students
select  count(stuName) from Students
=======
use JGWnameDB

--ÿһ�β�ѯ�����ǲ�������� 
--���Ų�ѯ�Ľ���������ű��ģʽ��ʾ

--c# �����û� ����
--��ҵ����棿
--����վ����winform���õ�������
--�� as ����
--�� �ո�  ����
--����=��

--���� ��������Ĭ���������
--order by <���������>
select * from Students
where   sex='��'
order by  stuno
--order by  ������������ѧ�����飬����ɸѡ�����������,asc����desc����
--asc �����С����
--desc ����Ӵ�С
--����
select  stuno from Students
order by  stuno asc
--����
select  stuno from Students
order by  stuno desc	

--��ѯ�﷨
--select  ����
--from  ����
--where ��������
--order  by   ����[asc��desc]     
select  ClassShcoolID,stuName
from Students
where  sex='��'
order by   stuNo

--�ַ����ϲ��У��ֶη����ͣ�  �ַ���+�ַ���=ƴ�ӣ� ����+����=����
--convertת����cast�� convert(varchar,ClassShcoolID),cast(stuno as varchar) 
select  convert(nvarchar,classshcoolid)+stuName
from Students

--�ַ����ղ���null,ʲô��û�У������=null�����󴴽�֮��û�и�ֵ
--�ж����ݶο� where  creattime is null


--���ƹ̶�����
--1�����ƹ̶����У�top 1
select top 4 stuNo from Students

--2�����ٷֱ���ʾ���� top 2 percent
select top 80  percent ClassShcoolID from Students


--�ַ��������ļ��ຯ��
--charindex��var1��var2��var3����Ѱ��һ��ָ���ַ�������һ���ַ����п�ʼ��λ�ã�û�����ִ�Сд
--����1����ѯ�Ĳ���������2�����������ַ���������3�������ؿ�ʼ�ң����ݿ�������ַ��������ĳ����Ǵ�0��ʼ��
select stuname from students where stuno=1004
select CHARINDEX('��','������',1) stuname
from Students

--�ַ������ȣ�len��'�ַ���'��,���ش��ݸ������ַ�������
select stuname  from Students  where len(stuname)>=3

--upper�����ַ�����СдתΪ��д upper('�ַ���')
select upper('wenqiaocui')

--ltrim:�����ߵĿո� ltrim('�ַ���')
select LTRIM('  ����')

--rtrim������ַ����ұߵĿո�  rtrim��'�ַ���'��

--right:���ַ����ұ߷���ָ����Ŀ���ַ�  right��'�ַ���',1��

--replace���滻һ���ַ����е��ַ� replace('�ַ���','var1','var2')��var1��ʾΪ��Ҫ�滻���ַ���var2��ʾ�滻��ֵ
select  replace('������������','��������','�¸��԰�')

--stuff����һ���ַ����У�ɾ��ָ��������ָ�����ȣ����Ҳ���һ���µ��ַ�����stuff��'�ַ���1',2��������,3��������,'�ַ���2'��
select  stuff('����',2,1,'��˧')


--���ں���
--getdate��ȡ�õ�ǰʱ�� select getdate���������ؽ�������
select getdate()

--dateadd����ָ�����ּӵ����ڵ�ָ������ select  dateadd(mm,4,'01/01/2009'),����ֵ5/1/2009

--datediff����������֮���ָ�����ڲ��ֵļ�� select datediff��mm,'01/01/2001','05/01/2001'��������4

--datename��������ָ�����ڲ��ֵ��ַ�����ʽ select datename��mm,'01/01/2000'�� ���� ����������saturday

--datepart��������ָ�����ڲ��ֵ�������ʽ select datepart��day,'01/15/2000'�� ����15

--��õ�ǰ���ڵĸ��ָ�ʽ,��convertת������ת���ַ�����ʽ��֮��ѡ�����ָ�ʽ������ٶ�selserver��convertת�����ڸ�ʽ
select CONVERT(varchar,GETDATE(),111)

select (DATEADD (day,1,getdate()))
--c# yy�� MM��  dd��  hhСʱ   mm��  ss��
--sql  yy��  mm��   dd��  m��   


--��ѧ����
--rand �����ش�0��1�����floatֵ�� select rand����

--abs��ȡ��ֵ���ʽ�ľ���ֵ select abs����ѧ���ʽ��

--geiling��ȡ���ڻ����ָ����ֵ�����ʽ����С���� select  getling��43.5��  ����ֵ44

--floor��ȡС�ڻ����ָ����ֵ�����ʽ��������� select floor��43.5�� ����ֵ43

--power��ȡ��ֵ���ʽ����ֵ select power��5��2�� ����ֵ25  5^2

--rouno:����ֵ���ʽ��������Ϊָ������ select rouno��43.543��1�� ����ָ43.5

--sigh: ������������ֵ+1�����ڸ�������ֵ-1������0����0�� select sigh��-43�� ����ֵ-44

--sqrt;ȡ������ʽ��ƽ���� select sqrt��9�� ����ֵ3



--ϵͳ����
--convert������ת����������convert ��varchar,12334��

--current_use: ���ص�ǰ�û�����select current_use

--datalength����������ָ�����ʽ���ֽ�����select datalength

--host_name:���ص�ǰ�����������ļ�������֣�select host_name()

--system_user:���ص�ǰ��������û����ƣ�select system_user

--user_name: �Ӹ������û�id�����û�����select user_name(1)�� ����ֵ���������ݿ��з���'db0'



--��ѯ���ú���
--LIKE,BETWEEN,IN����ģ����ѯ
--ʹ�þۺϺ���ͳ�ƺͻ��ܺ���

--ģ����ѯ,��֪���������Ϣ��ֻ֪��һ����
--ģ����ѯlike,����ƥ���ν�������ѯ����Ϣ������ѡ��ɸѡ��������֪���������Ϣ��ֻ֪��һ����
--like
--ͨ���1��_����ʾһ���ַ���A LIKE '��_'  ��ʾ ��cs������  ��Щ����
--ͨ���2��%����ʾ���ⳤ�ȣ�B LIKE	'��_',��ʾֻҪ�����ŵ����ݶ���ȡ����
--ͨ���3��[]:��ʾ�涨�ĳ��ȷ�Χ��C LIKE '��[1-2]',��ʾ�ŵĺ������2��3���ַ�������ȫ����ȡ������
--ͨ���4��[^]���������ŷ�Χ���������ȡ���� ��D LIKE '��[^1-2]' ,
select *from  Students
where stuName like '��%'  

--in ����/not in ������
select*from Students 
where stuNo in (1001,1002,1003)
--truncate table students�ָ������ʼ
truncate table students
--��ҳ
select top 3* from  Students
where stuNo in (1,2,3)

select top 3*from Students
where stuno in(4,5,6)

select  top 3*from Students 
where stuNo in(7,8,9)

--ǰ���У�Ϊһҳ
select top 3 * from Students

--������Ϊһҳ
select top 3* from Students
where  stuNo not in (select top 3 *from Students)


--between �Ƽ�ʹ��
--���ֺ����ڵ�ɸѡ
--����������С����Ĳ��ң�Ч�����bettwwn ��С�������
select * from Students
where stuno between 1 and 3



--�ۺϺ������� ���ֵmax ��Сֵ min �ܺ� sum, ƽ��avg ֻ���������� ͳ�Ƽ�¼count������ͳ���ַ��������ڣ�null������ͳ�ƣ�һ��������ͳ��
select  max(qian) as zuidazhi from Students
select min(qian) from Students
select  avg(qian) from Students
select sum(qian)  from Students
select  count(stuName) from Students
>>>>>>> 45f0c71 (new)
