--��̬�α꣬����Զ�λ�����Զ�λ�������ҵ��̶���ĳһ�У�
--���徲̬�α꣬�������α��֮�󣬵õ�������ѯ�����ݼ�֮��
--��û�йر�֮ǰ���������ڲ�ѯ�ı�����ɾ���κ����ݣ��α��еõ������ݼ�����ı�
--��̬�α�Ҳ�ǿ������¶�ȡ
declare product_cursor cursor  static
for 
select *from ProductInfos

--���α�
open product_cursor

--�����Ӧ�α���������ı���
declare @cursorvarchar cursor,@��Ʒid int,@��Ʒ��  varchar(50),@��Ʒ���� money
set @cursorvarchar=product_cursor
fetch next from  @cursorvarchar into  @��Ʒid,@��Ʒ��,@��Ʒ����
print cast(@��Ʒid as varchar(50))+@��Ʒ��+cast(@��Ʒ���� as varchar(50))

close @cursorvarchar
deallocate  @cuesorvarchar




--��̬�α�,������Ƕ�̬�Ľ����������ѯ�����ݼ����ı�֮�����Ӧ���α�Ҳ��ı�
--��̬�α꣬�������϶�ȡ�������¶�ȡ
declare product_cursor_dynamic cursor  dynamic
for 
select *from ProductInfos

--���α�
open product_cursor

--�����Ӧ�α���������ı���
declare @cursorvarchar1 cursor,@��Ʒid1 int,@��Ʒ��1  varchar(50),@��Ʒ����1 money
set @cursorvarchar=product_cursor_dynamic
fetch next from  @cursorvarchar into  @��Ʒid1,@��Ʒ��1,@��Ʒ����1
print cast(@��Ʒid1 as varchar(50))+@��Ʒ��1+cast(@��Ʒ����1 as varchar(50))

close @cursorvarchar
deallocate  @cuesorvarchar