CREATE TABLE `school_school` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '学校信息主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '学校名称',
  `shortname` varchar(45) NOT NULL DEFAULT '' COMMENT '学校短名称',
  `logo` varchar(200) NOT NULL DEFAULT '' COMMENT '学校logo',
  `introduction` varchar(200) NOT NULL DEFAULT '' COMMENT '简介',  
  `cityid` int(11) NOT NULL DEFAULT '0' COMMENT '所属城市',  
  `address` varchar(100) NOT NULL DEFAULT '' COMMENT '地址',
  `longitude` DECIMAL(14,6) NOT NULL DEFAULT '0.0' COMMENT '经度',
  `latitude` DECIMAL(14,6) NOT NULL DEFAULT '0.0' COMMENT '纬度',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='学校信息';
