<<<<<<< HEAD
--��ͼ
--���ݿ��ֶΣ�����
--���ܣ����ĵ�,�ڶ���������ݿ�ṹ���ң�
--��ͼ�е�
--1�������ֶΣ�����������Ϣ
--2���򻯲�ѯ

--�򻯲�ѯ��������ͼ����ͼ�൱��һ�������
--create database ���������ݿ�
--create  table ������
--����ͼ����һ�ű�ʹ�ã�������������ͼ��֮��
--���Խ�������ͼ�Ĵ���ɾ����֮��ֱ�ӵ�����ͼ��
--�Ϳ��Բ�ѯ����ͼ
--alter�޸ı�update���޸�����
alter view view_Getstudents 
as
select *from students
inner join classinfos
on  students.classshcoolid=classinfos.jgwshcoolid
--����ͼ��������ɾ��ֻҪ�ɹ����ǻ�Ӱ��ԭ����������
--����ǵ����ǿ��Բ����ģ����Ƕ����ɵ���ͼ�ǲ����ᱨ��

--���԰���ͼҲ����һ�ű�����Ҫ��ѯ����Ϣ���Ѿ���Ϊ��һ����ͼ�����ǿ���ֱ������ͼ������
select  *from view_Getstudents as a
inner join  shcoolinfos as b
on (a.JGWshcoolID=b.ClassID)
--��ͼ����Ƕ����ͼ����ͼ����������order by��������ͼ��ʱ�򣬲���ʹ��order by
--into��¡��ṹ������Ҳ����ʹ��

--����ѯ(���ݿ���) ..����
select *from cwdb..cwinfos
=======
--��ͼ
--���ݿ��ֶΣ�����
--���ܣ����ĵ�,�ڶ���������ݿ�ṹ���ң�
--��ͼ�е�
--1�������ֶΣ�����������Ϣ
--2���򻯲�ѯ

--�򻯲�ѯ��������ͼ����ͼ�൱��һ�������
--create database ���������ݿ�
--create  table ������
--����ͼ����һ�ű�ʹ�ã�������������ͼ��֮��
--���Խ�������ͼ�Ĵ���ɾ����֮��ֱ�ӵ�����ͼ��
--�Ϳ��Բ�ѯ����ͼ
--alter�޸ı�update���޸�����
alter view view_Getstudents 
as
select *from students
inner join classinfos
on  students.classshcoolid=classinfos.jgwshcoolid
--����ͼ��������ɾ��ֻҪ�ɹ����ǻ�Ӱ��ԭ����������
--����ǵ����ǿ��Բ����ģ����Ƕ����ɵ���ͼ�ǲ����ᱨ��

--���԰���ͼҲ����һ�ű�����Ҫ��ѯ����Ϣ���Ѿ���Ϊ��һ����ͼ�����ǿ���ֱ������ͼ������
select  *from view_Getstudents as a
inner join  shcoolinfos as b
on (a.JGWshcoolID=b.ClassID)
--��ͼ����Ƕ����ͼ����ͼ����������order by��������ͼ��ʱ�򣬲���ʹ��order by
--into��¡��ṹ������Ҳ����ʹ��

--����ѯ(���ݿ���) ..����
select *from cwdb..cwinfos

create view view_Getstudents 
as
select *from students
inner join classinfos
on  students.classshcoolid=classinfos.jgwshcoolid
>>>>>>> 45f0c71 (new)
