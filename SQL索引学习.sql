select * from Testinfos
with(index=pk_testinfos)

--�Ǿۼ�����nonclustered
--Ψһ����ѡunique
--����Ψһ�ķǾۼ�����
create unique nonclustered
index testinfos_name  --���������ƣ�ȷ��Ψһ��������
on testinfos(name)
with fillfactor=60 --������Ӱٷֱ�0-100֮��


select * from sysindexes  --ϵͳ��������
where name='testinfos_name'


--ʹ��������ѯ
select * from testinfos
with (index=testinfos_name)--ʹ��������ѯ����ʲô����ȥ��
where name='iphone�ֻ�'



--57��ͬѧ
--�������57����
--�������Ϊ0ʱ�������м�û�пռ�
--�����ڹ�������ʱ��һ����趨��������ӵİٷֱ�
--������м����һ�����ݵ�ʱ���������ݶ�Ҫ����

--��ͼ���򻯲�ѯ�ķ�ʽ