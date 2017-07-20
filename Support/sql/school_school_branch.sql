CREATE TABLE `school_school_branch` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '学校信息主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '分校名称',
  `shortname` varchar(45) NOT NULL DEFAULT '' COMMENT '分校短名称',  
  `logo` varchar(200) NOT NULL DEFAULT '' COMMENT '分校logo',
  `introduction` varchar(200) NOT NULL DEFAULT '' COMMENT '分校简介',  
  `schoolid` int(11) NOT NULL DEFAULT '0' COMMENT '所属学校',  
  `cityid` int(11) NOT NULL DEFAULT '0' COMMENT '所属城市',  
  `address` varchar(100) NOT NULL DEFAULT '' COMMENT '分校地址',
  `longitude` DECIMAL(14,6) NOT NULL DEFAULT '0.0' COMMENT '分校经度',
  `latitude` DECIMAL(14,6) NOT NULL DEFAULT '0.0' COMMENT '分校纬度',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='分校信息';
