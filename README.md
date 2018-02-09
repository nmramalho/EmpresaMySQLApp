# EmpresaMySQLApp
Aplicação que permite realizar operações CRUD (Create, Read, Update, Delete) numa base de dados MySQL. 
As operações vão ser realizadas através de um formulário Windows (Windows Form). É utilizada uma base de dados de uma empresa, que vai conter dados relativos aos seus departamentos, nomeadamente as iniciais e nome dos departamentos. Vai também armazenar os dados dos seus funcionários. Cada funcionário é identificado por um número, o departamento a que pertence e o nome. Cada funcionário pertence apenas a um departamento. 

# Script para criação da base de dados

```
CREATE DATABASE empresa DEFAULT CHARACTER SET utf8;

USE empresa;

CREATE TABLE departamento (
  id VARCHAR(10) NOT NULL,
  nome VARCHAR(50) NOT NULL,
  PRIMARY KEY (id));
  
INSERT INTO departamento (id, nome) VALUES ('DI', 'Departamento de Informática');
INSERT INTO departamento (id, nome) VALUES ('DL', 'Departamento de Limpeza');
INSERT INTO departamento (id, nome) VALUES ('DC', 'Departamento de Contabilidade');
INSERT INTO departamento (id, nome) VALUES ('DRH', 'Departamento de Recursos Humanos');
INSERT INTO departamento (id, nome) VALUES ('DS', 'Departamento de Segurança');
```

