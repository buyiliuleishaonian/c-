<<<<<<< HEAD
--������ ������䲻��һ������
--���ݿ���������
--���������ֻ����ɾ�ģ���ѯ����ı�����
--insert  delete  update  select(��Ӱ������)
--���ݿ��һ�֣���ʾ���� begin transaction
--ϵͳ����������T-SQL���ִ�д�����@@error
use jgwnamedb
begin transaction--��ʼ����
declare @num int=0
update students
set stuname='������'
where stuname='����'
set @num=@num+@@error--���ִ���Ϊ1
update students
set stuName='������'
where stuname='����'
set @num=@num+@@error
if @num=0
begin
print 'ת�ʳɹ�'
commit transaction--�ύҵ��
end
else --�������
begin
print 'ת��ʧ��'+cast(@num as varchar)
rollback transaction--�ͻع���Ϣ
end


--���ݿ�ڶ��֣��Զ�����commit transaction��SQL server��Ĭ��ģʽ
--ÿ������T-SQL�����Ϊһ������

--���ݿ�����֣���ʽ����ͨ������set implicit_transactions on���
--������ʽ����ģʽ����Ϊ�򿪣�����T-SQL����Զ�����һ��������
--�ύ��ع�һ���������һ��T-SQL����ֽ�����һ�������񣬱�֤����ĸ�����


set implicit_transactions on--����ʽ�����������ʽ����ʹ�����ɾ���޸ģ���������������������Ϣ�����Ǳ��Ѿ�ִ�в���
--���ڵȴ���һ��ָ��ȴ��ύ����ȡ��  rollback��ȡ��  commit�ύ
commit
rollback
--oracle��Ĭ����ʽ��������sqlserverĬ����ʽ����ر�
=======
--������ ������䲻��һ������
--���ݿ���������
--���������ֻ����ɾ�ģ���ѯ����ı�����
--insert  delete  update  select(��Ӱ������)
--���ݿ��һ�֣���ʾ���� begin transaction
--ϵͳ����������T-SQL���ִ�д�����@@error
use jgwnamedb
begin transaction--��ʼ����
declare @num int=0
update students
set stuname='������'
where stuname='����'
set @num=@num+@@error--���ִ���Ϊ1
update students
set stuName='������'
where stuname='����'
set @num=@num+@@error
if @num=0
begin
print 'ת�ʳɹ�'
commit transaction--�ύҵ��
end
else --�������
begin
print 'ת��ʧ��'+cast(@num as varchar)
rollback transaction--�ͻع���Ϣ
end


--���ݿ�ڶ��֣��Զ�����commit transaction��SQL server��Ĭ��ģʽ
--ÿ������T-SQL�����Ϊһ������

--���ݿ�����֣���ʽ����ͨ������set implicit_transactions on���
--������ʽ����ģʽ����Ϊ�򿪣�����T-SQL����Զ�����һ��������
--�ύ��ع�һ���������һ��T-SQL����ֽ�����һ�������񣬱�֤����ĸ�����


set implicit_transactions on--����ʽ�����������ʽ����ʹ�����ɾ���޸ģ���������������������Ϣ�����Ǳ��Ѿ�ִ�в���
--���ڵȴ���һ��ָ��ȴ��ύ����ȡ��  rollback��ȡ��  commit�ύ
commit
rollback
--oracle��Ĭ����ʽ��������sqlserverĬ����ʽ����ر�
>>>>>>> 45f0c71 (new)
--sqlconnection ���Ӷ��� conn.close() �رջ㻰����