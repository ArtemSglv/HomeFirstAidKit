CREATE TABLE Medicament (
	ID_med INT,
	ID_cat INT,
	Name CHAR(40),
	Shelf_life DATE,
	Application CHAR(40),
	constraint MEDICAMENT_PK PRIMARY KEY (ID_med)
);
CREATE TABLE Category (
	ID_cat INT,
	Name CHAR(40),
	constraint CATEGORY_PK PRIMARY KEY (ID_cat)
);
CREATE TABLE Disease (
	ID_disease INT,
	Name CHAR(40),
	ID_symptom INT,
	constraint DISEASE_PK PRIMARY KEY (ID_disease)
);
CREATE TABLE Symptom (
	ID_symptom INT,
	Name CHAR(40),
	constraint SYMPTOM_PK PRIMARY KEY (ID_symptom)
);
CREATE TABLE Medicament_Disease (
	ID_med INT,
	ID_disease INT,
	constraint MEDICAMENT_DISEASE_PK PRIMARY KEY (ID_med,ID_disease)
);
CREATE TABLE Disease_Symptom (
	ID_disease INT,
	ID_symptom INT,
	constraint DISEASE_SYMPTOM_PK PRIMARY KEY (ID_disease,ID_symptom)
);

ALTER TABLE Medicament ADD CONSTRAINT Medicament_fk0 FOREIGN KEY (ID_cat) REFERENCES Category(ID_cat);

ALTER TABLE Medicament_Disease ADD CONSTRAINT Medicament_Disease_fk0 FOREIGN KEY (ID_med) REFERENCES Medicament(ID_med);
ALTER TABLE Medicament_Disease ADD CONSTRAINT Medicament_Disease_fk1 FOREIGN KEY (ID_disease) REFERENCES Disease(ID_disease);

ALTER TABLE Disease_Symptom ADD CONSTRAINT Disease_Symptom_fk0 FOREIGN KEY (ID_disease) REFERENCES Disease(ID_disease);
ALTER TABLE Disease_Symptom ADD CONSTRAINT Disease_Symptom_fk1 FOREIGN KEY (ID_symptom) REFERENCES Symptom(ID_symptom);