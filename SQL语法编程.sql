<<<<<<< HEAD
use jgwnamedb

--��ѯһ��ѧ����
--֮�����ٽ���Ҳ��ѯ����

declare  @id int=0
select @id=classid  from shcoolinfos
where  studentsname='��֤'

select studentsname from  ShcoolInfos
where classid=@id+1  or  classid=@id-1


--�������2��
print 'aaa'--��ʾ���������ʹ�û���ã�ֱ������ı�
select 'aaa' --��ʾ��������Ե��ã�������Ǳ�����͵�

--����ת�� cast convert���ַ�ʽ
declare @str  varchar(10)='��'
select   @str +cast(1 as varchar)

select getdate()
select convert(varchar,getdate(),113)
--convert����ָ��ת����ʽ


--�ж����
declare @num int=9
if @num<10
begin
 print '��'
end
else
begin
print '���'
end


--�����ɾ�Ĳ�ֻ��һ����GOû���κ�����
--һ��洢������go
go--��������ִ������ʹ��


--��Ҫbegin end �������ֻ��һ����begin end�൱����һ��������{}

--case	end
--�����﷨:��һ�̶ֹ�ֵ�ж�
--		  ;��ʾ��Χ�жϺ��滻
--������������Ϊbit������Ů��
select (case sex when 1 then '��' else  'Ů' end ) as sex from students
select sex=case sex when 1 then '��' else 'Ů' end from students

--select 
--����= case  when ���� between  100 and 90 then 'A'
			--when ����  between  89 ���� 80 then 'B'
			--when  ����>=70 and ����<=79 then 'C'
			--end
--from ����
 --���κ������select��ѯ�ǲ����޸Ľ����

--һ�㶼ʹ��varchar��nvarchar,�������ĳ�������һ����uncoding��һ��uncoding����




=======
use jgwnamedb

--��ѯһ��ѧ����
--֮�����ٽ���Ҳ��ѯ����

declare  @id int=0
select @id=classid  from shcoolinfos
where  studentsname='��֤'

select studentsname from  ShcoolInfos
where classid=@id+1  or  classid=@id-1


--�������2��
print 'aaa'--��ʾ���������ʹ�û���ã�ֱ������ı�
select 'aaa' --��ʾ��������Ե��ã�������Ǳ�����͵�

--����ת�� cast convert���ַ�ʽ
declare @str  varchar(10)='��'
select   @str +cast(1 as varchar)

select getdate()
select convert(varchar,getdate(),113)
--convert����ָ��ת����ʽ


--�ж����
declare @num int=9
if @num<10
begin
 print '��'
end
else
begin
print '���'
end


--�����ɾ�Ĳ�ֻ��һ����GOû���κ�����
--һ��洢������go
go--��������ִ������ʹ��


--��Ҫbegin end �������ֻ��һ����begin end�൱����һ��������{}

--case	end
--�����﷨:��һ�̶ֹ�ֵ�ж�
--		  ;��ʾ��Χ�жϺ��滻
--������������Ϊbit������Ů��
select (case sex when 1 then '��' else  'Ů' end ) as sex from students
select sex=case sex when 1 then '��' else 'Ů' end from students

--select 
--����= case  when ���� between  100 and 90 then 'A'
			--when ����  between  89 ���� 80 then 'B'
			--when  ����>=70 and ����<=79 then 'C'
			--end
--from ����
 --���κ������select��ѯ�ǲ����޸Ľ����

--һ�㶼ʹ��varchar��nvarchar,�������ĳ�������һ����uncoding��һ��uncoding����




>>>>>>> 45f0c71 (new)
