#drop database if exists propertydb;
#create database propertyDB;
use propertyDB;
 
DROP TABLE IF EXISTS property;
#Create property table. Add property name. 
CREATE TABLE `property` (
	`property_no` int(11) auto_increment,
    `property_name` varchar(255) default null,
    `property_address` text default null,
    `post_code` varchar(255) default null,
    `property_type` varchar(255) default null,
    `property_price` varchar(255) default null,
    `max_no_occupancy` int default null,
    `multiple_occupancy` tinyint(1) not null,
    `resident_status` varchar(255) not null,
    `pets_allowed` varchar(25) not null,
    `children_allowed` varchar(25) not null,
    PRIMARY KEY (`property_no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#insert values
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Block A, Flat14", "Nixon Court, 33 Putney Road, Leicester", "LE2 7TG", "Student Flat", "£430 pcm", "Student", 6, 1, "no", "no");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Block B, Flat12", "Nixon Court, 33 Putney Road, Leicester", "LE2 7TG", "Student Flat", "£430 pcm", "Student", 6, 1, "no", "no");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Flat 11, Regent Place", "44 Church Road, Luton", "LU4 3JP", "Flat", "£500 pcm", "Non-Student", 4, 1, "yes", "yes");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Chris Wilkinsons House", "23 Gramby Street, Moss Side, Manchester", "M44 3JG", "House", "£650 pcm", "Non-Student", 4, 1, "yes", "yes");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("2 Bedroom Flat", "Steel Grove, 33 Jubely Road, Leicester", "LE1 5PB", "Appartment", "£751 pcm", "Non-Student", 2, 1, "yes", "yes");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Bourmount Gardends", "17 Narbourough Road, Leicester", "LE3 5JQ", "Appartment", "£850 pcm", "Non-Student", 1, 0, "no", "no");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Block E, Flat506", "Nixon Court, 33 Putney Road, Leicester", "LE2 7TG", "Student Flat", "£430 pcm", "Student", 6, 1, "no", "no");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Slough Gardens", "Nixon Court, 30 Putney Road, Leicester", "LE2 7TP", "House", "£330 pcm", "Student", 4, 1, "no", "no");

/*
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Cherry Gardens", "Nixon Court, 30 Putney Road, Leicester", "LE2 7TP", "House", "£330 pcm", "Student", 4, 1, "no", "no");
*/
/*

INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Block A, Flat14", "Nixon Court, 33 Putney Road, Leicester", "LE2 7TG", "Student Flat", "£430 pcm", "Student", 6, 1, "no", "no");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Block B, Flat12", "Nixon Court, 33 Putney Road, Leicester", "LE2 7TG", "Student Flat", "£430 pcm", "Student", 6, 1, "no", "no");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Block A, Flat14", "Nixon Court, 33 Putney Road, Leicester", "LE2 7TG", "Student Flat", "£430 pcm", "Student", 6, 1, "no", "no");
INSERT INTO property (property_name, property_address, post_code, property_type, property_price, resident_status, max_no_occupancy, multiple_occupancy, pets_allowed, children_allowed)
VALUES ("Block B, Flat12", "Nixon Court, 33 Putney Road, Leicester", "LE2 7TG", "Student Flat", "£430 pcm", "Student", 6, 1, "no", "no");
*/

DROP TABLE IF EXISTS `lettings`;
#Create the lettings table
CREATE TABLE `lettings` (
	`rental_no` int(11) auto_increment,
    `current_status` tinyint(1) default NULL, #0 for empty, 1 for let 
    `lease_arrangement` date default NULL, 
    `is_available` tinyint(1) default NULL,
    `property_no` int(11) NOT NULL,
    PRIMARY KEY (`rental_no`),
    FOREIGN KEY (`property_no`) REFERENCES property(`property_no`) 

    #reference provided to primary key. 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#Insert Data 
INSERT INTO lettings (current_status, lease_arrangement, is_available, property_no)
VALUES (1, '2019-07-14', 0, 1);
INSERT INTO lettings (current_status, lease_arrangement, is_available, property_no)
VALUES (1, '2019-07-14', 0, 2);
INSERT INTO lettings (current_status,lease_arrangement, is_available, property_no)
VALUES (1, '2019-07-14', 0, 3);

INSERT INTO lettings (current_status,lease_arrangement, is_available, property_no)
VALUES (0, NULL, 1, 4);
INSERT INTO lettings (current_status,lease_arrangement, is_available, property_no)
VALUES (0, NULL, 1, 5);
INSERT INTO lettings (current_status, lease_arrangement, is_available, property_no)
VALUES (0, NULL, 1, 6);
INSERT INTO lettings (current_status, lease_arrangement, is_available, property_no)
VALUES (0, NULL, 1, 7);
INSERT INTO lettings (current_status,lease_arrangement, is_available, property_no)
VALUES (0, NULL, 1, 8);


#Display values stored in each entity
select * from property;
select * from lettings;

/*
select property.property_name, property.property_address, property.property_price, property.max_no_occupancy, 
property.multiple_occupancy,property.resident_status, property.pets_allowed, lettings.current_status, lettings.is_available, 
property.children_allowed from property inner join lettings on lettings.property_no = property.property_no where property.resident_status = 'Student' and lettings.is_available = 1;
*/

#select * from property inner join lettings on lettings.property_no = property.property_no where property.resident_status = 'Student' and lettings.is_available = 1;


