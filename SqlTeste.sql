 create table tb_Funcionarios
 (i_func_id int identity(1,1) primary key, 
  vc_func_nome varchar(200),
  vc_func_funcional varchar(50),
  vc_func_filial varchar (50));
 
 
 select * from tb_Funcionarios;
 
 insert into tb_Funcionarios (vc_func_nome, vc_func_funcional, vc_func_filial)
 values ('Paulo da Silva', '00015', 'RJ');
 
  insert into tb_Funcionarios (vc_func_nome, vc_func_funcional, vc_func_filial)
 values ('Alexandre Gomes', '00017', 'RJ');
 
  insert into tb_Funcionarios (vc_func_nome, vc_func_funcional, vc_func_filial)
 values ('Joel Ortega', '00033', 'SP');
 
  insert into tb_Funcionarios (vc_func_nome, vc_func_funcional, vc_func_filial)
 values ('Bruno Cardoso', '00035', 'SP');