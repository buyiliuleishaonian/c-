use JGWnameDB
--������-����ڱ���ӣ�ɾ�����޸�(����)
--����ĳ�ű���Ӷ�������������������һ�ű����һ��������¼

--��������Լ��������Լ����
--�����������Լ����ʱ����Ҫɾ�����������ݣ��ӱ�Ҳɾ��ʱ��Ҫ�ô�����


--ʵ����ֻ�����ֶ����ݿ���Ӱ�죬ֻ����ӣ�ɾ�����޸ĵı�������ɾ���������
--��ʱ��ϵͳ��ʱ��  inserted(��Ӽ�¼)  deleted(ɾ����¼)

--trigger  ������

--1��������������������ĳ������
create trigger tri_Test1  --�������������޸���alter
on test1  --�����Ĵ������������Ǹ���
for  insert,update,delete   ---after/inserted  of(����ɾ����Լ���ı�)
as
begin
	--�൱������
	declare @name  varchar(50)--������
	declare @����  varchar(50)
	declare @sum  int--ͳ��
	if  exists(select top 1 * from deleted)
	begin
	 select @name=name from deleted
	 set	@����='ɾ��'
	 set  @sum=@sum+1
	end
	if  exists (select top 1 * from inserted)
	begin
	select @name=name from inserted
	 set  @����='���'
	 set  @sum=@sum+1
	end
	if  @sum=2
	begin
	select @name=name from deleted
	set  @����='�޸�'
	end

	--���������ڵı�����֮������һ�ű�ʵ�����ɾ���޸�
	--����д�ڼ�¼�����棬�����Ҫ����һ����Ļ�������Ҫ������Ӧ�ı�������ʵ�����Ӧ��
	--��ӣ�ɾ�����޸�
	insert  into  test2(name,����)
	values(@name,@����)
end