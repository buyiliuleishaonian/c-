use JGWnameDB
select * from testinfos
--execute
exec pro_GetProduct

---ʲô��Ԥ����
--�ص�:Ԥ���룬������
--�ŵ�:��߲�ѯЧ��
--�ŵ�:�洢���̣�T-SQL��ֻ��ͨ����������ʽ���ã���ȫ�Ը���
--�ŵ�:ģ�黯��̣����ܣ��洢����Ҳ���Ե��ô洢���̣�
--ȱ�㣺д��������


--�������η�������ֵ�����������βΣ�

--����һ���洢���̣��洢���̿��Թ�����ͼ��������ͼ�����Ե��ô洢����
--�﷨�淶PROC_
--���ֲ���������������������������ֵ
use jgwnamedb
create proc PROC_GetProduct(
	--�������
	@studentname  varchar(50),
	@studenthome  varchar(50),
	@studentnianji  int output
	--������������Զ�����
--һ�����������ǰ����������ں�
)--�β�
as
begin
	insert into shcoolinfos(studentsname,studentshome,StudentsNianji)
	values(@studentname,@studenthome)
	select  @qq=@@identity--����ֵ  ---��ȡ��ǰ������������id
	--return  @@indentity
end

--�洢���̣��޸�
alter  proc   PROC_GetProduct(
	--�������
	@studentname  varchar(50),
	@studenthome  varchar(50),
	@studentnianji  int  output--������������Զ�����
--һ�����������ǰ����������ں�
)--�β�
as
begin
	insert into shcoolinfos(studentsname,studentshome)
	values(@studentname,@studenthome)
	select  @studentnianji=@@identity--����ֵ  ---��ȡ��ǰ������������id���ֲ�������ͨ��select��ֵ�����ֵʱ��������ѯ�����һ��ֵ
	--return  @@indentity
end


--���ô洢����
--execute
--����洢�����У����������
--��Ҫ����һ����������
declare @qq1  int
execute PROC_GetProduct '����','�����Ƹ�',@qq1 output
select @qq1

--дһ������ֵ�Ĵ洢����
create proc PROC_GetShcoolinfos
(
	@studentname varchar(50),
	@studenthome varchar(50)--�������
)
as
begin
  insert into ShcoolInfos(StudentsName,Studentshome)
  values(@studentname,@studenthome)
  return  @@identity
end



--����ֵ
declare  @id1  varchar(50)
  exec  @id1=PROC_GetShcoolinfos '����','��������'--�Ż�ֵ

