<<<<<<< HEAD
--ѧϰT-SQL����ɾ�Ĳ�,�����ݿ����棬����''�������ţ�������������ͣ�����ӵ����ţ�������������ͣ����Ի򲻼ӵ�����
use JGWnameDB--��ʾ�����Ǹ����ݿ�
--����������������Ϊ��ʶ���У�������ʾ�ֶ�����
--�������潫ֵ�嵽���ݿ���������sqlparameter
--�������ӣ����п���Ϊnullʱ��������Բ�����ֵ��defaultȱʡֵ
insert into ClassInfos(JGWshcoolID,className1)
values(3,'java��')
--��ID��Ϊ��ʶ��ʱ������Ҫ�ֶ�����
insert into ClassInfos(className1)
values('�㷨��')
--�������ӣ�insert select 
insert into ClassInfos(JGWshcoolID,className1)
select 4,'ǰ�˰�'  union
select 5,'�㷨��' 
--�������ӣ�insert select �����еı��е�����ת����һ������ȥ
insert into Test(id,[name])
select JGWshcoolID,className1
from  ClassInfos

--ɾ������ɾ����
--delete    --drop�ṹɾ����ɾ����
--drop table ����
--delete
delete from ClassInfos --deleteʹ�ü������ܲ�������������ɾ������
where JGWshcoolID=5 --��������ɾ��������Ψһ����

--truncate table  ����ָ�����ʼ��С������ʶ�лָ�����������
truncate table Classinfos

--�� update
update Students --update����ӱ���
set   stuName='����',ClassShcoolID=2  --set�������Ҫ�޸ĵ���Ϣ
where   stuNo=1001 --һ��ɾ�����޸ģ�����Ҫ������Щ�����ģ����Զ�����and��or


--��*�����ʾȫ��
select * from ClassInfos
select *from Test

--*��������Զ��壬
--��ѯʱ�������б�N����Ϣ������ĳ��������Ϣ
--���Ե��ڴ�����text
select  '����',ClassShcoolID,sex from Students  where sex='��' 

-- union, union all
--�ϲ����ű����ϲ�ѯ�������ѯ��Ҫ���֮�����໥��ϵ
select  JGWshcoolID,className1  from  ClassInfos
union --�ϲ����ű���������ȥ���ظ���Ч��û��ouion all��
select id,name  from Test

--�ϲ����ű������Ľ���������һ��
select JGWshcoolID ,className1 from ClassInfos
union all 
select id,name from Test



--��ͨ��insert delete update�����Ͽ��Իָ�
--��table �Ǽ�ʱ�Եģ������Իָ�
=======
--ѧϰT-SQL����ɾ�Ĳ�,�����ݿ����棬����''�������ţ�������������ͣ�����ӵ����ţ�������������ͣ����Ի򲻼ӵ�����
use JGWnameDB--��ʾ�����Ǹ����ݿ�
--����������������Ϊ��ʶ���У�������ʾ�ֶ�����
--�������潫ֵ�嵽���ݿ���������sqlparameter
--�������ӣ����п���Ϊnullʱ��������Բ�����ֵ��defaultȱʡֵ
insert into ClassInfos(JGWshcoolID,className1)
values(3,'java��')
--��ID��Ϊ��ʶ��ʱ������Ҫ�ֶ�����
insert into ClassInfos(className1)
values('�㷨��')
--�������ӣ�insert select 
insert into ClassInfos(JGWshcoolID,className1)
select 4,'ǰ�˰�'  union
select 5,'�㷨��' 
--�������ӣ�insert select �����еı��е�����ת����һ������ȥ
insert into Test(id,[name])
select JGWshcoolID,className1
from  ClassInfos

--ɾ������ɾ����
--delete    --drop�ṹɾ����ɾ����
--drop table ����
--delete
delete from ClassInfos --deleteʹ�ü������ܲ�������������ɾ������
where JGWshcoolID=5 --��������ɾ��������Ψһ����

--truncate table  ����ָ�����ʼ��С������ʶ�лָ�����������
truncate table Classinfos

--�� update
update Students --update����ӱ���
set   stuName='����',ClassShcoolID=2  --set�������Ҫ�޸ĵ���Ϣ
where   stuNo=1001 --һ��ɾ�����޸ģ�����Ҫ������Щ�����ģ����Զ�����and��or


--��*�����ʾȫ��
select * from ClassInfos
select *from Test

--*��������Զ��壬
--��ѯʱ�������б�N����Ϣ������ĳ��������Ϣ
--���Ե��ڴ�����text
select  '����',ClassShcoolID,sex from Students  where sex='��' 

-- union, union all
--�ϲ����ű����ϲ�ѯ�������ѯ��Ҫ���֮�����໥��ϵ
select  JGWshcoolID,className1  from  ClassInfos
union --�ϲ����ű���������ȥ���ظ���Ч��û��ouion all��
select id,name  from Test

--�ϲ����ű������Ľ���������һ��
select JGWshcoolID ,className1 from ClassInfos
union all 
select id,name from Test



--��ͨ��insert delete update�����Ͽ��Իָ�
--��table �Ǽ�ʱ�Եģ������Իָ�
>>>>>>> 45f0c71 (new)
