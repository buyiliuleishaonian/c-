use [ѧϰ�α�ʹ�����DB]
truncate table  productinfos
--�α�
--SQLserver�����ݷ��ʵ�һ�ֻ��ƣ��������û������ݽ�����������ķ���
--���ʶ��ǵ�����䣬��������
--���ݽ�������α�
--�����α�
--ֻ���α�
--��̬�α�static
--��̬�α�dynamic

--�α��﷨;1�������α�  2���򿪲�ѯ�Ľ���� 3��ʹ��  4���ر� 5���ͷţ�Ҳֻ���ڶ����α�ĻỰ���Ự�����α�Ҳ�ͽ���
--ֻ���αֻ꣬�������ߣ����£���;�޷��ı䣩���ߵ�ͷ�������ݸı�֮��Ҳ��ı�
--�����α꣨һ��д�ڴ洢�����У�����������Ҫ��ѯ�Ľ����
declare product_cursor cursor for
select *from ProductInfos
--���α꣬ȫ��global������洢���̣�������ʹ�úͱ���  local�����أ�ֻ���ڱ���������ʹ��
open product_cursor 
--ʹ���α�
--1�������������ڴ����Ϣ�ı����������α�����Ų�ѯ��������α꣬���������д��ڵ��е��������͵ı�����
--@varCousor  cursor ���ڴ�ŵ�������
--2�����α��ֵ��ֵ�������cousor�ı���
--fetch next from  cursor����  into	 ����ı�������Ӧ��������е��������ͣ�	�α�ǰ�����൱����C#��sqldatareader���еķ���reader
--next ���£�prior ����
declare @cursorvarchar cursor,@��Ʒid int,@��Ʒ��  varchar(50),@��Ʒ���� money
set @cursorvarchar=product_cursor
fetch next from  @cursorvarchar into  @��Ʒid,@��Ʒ��,@��Ʒ����
--����ȡ���������ݼ���һһ��ȡ����
while @@FETCH_STATUS=0  --ר���������α��У��ж��Ƿ��α��е�����ȫ����ȡ��������
begin
  --print  @cursorvarchar
  print cast(@��Ʒid as varchar(50))+@��Ʒ��+cast(@��Ʒ���� as varchar(50))
  fetch next from  @cursorvarchar into @��Ʒid,@��Ʒ��,@��Ʒ����
end

--�ر��α꣬close�ر�
close @cursorvarchar--��Ϊ�Ѿ����α긳ֵ���α������������Ҫ�ر��α����
--�ͷ���Դ��deallocate�ͷ�
deallocate @cursorvarchar





--������
--Ԥ������﷨�ṹ
