CREATE TABLE `config_city` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '城市信息主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '城市名称',
  `ename` varchar(100) NOT NULL DEFAULT '' COMMENT '城市英文名称',
  `citycode` varchar(100) NOT NULL DEFAULT '' COMMENT '城市三字码',
  `zipcode` varchar(100) NOT NULL DEFAULT '' COMMENT '邮编',
  `provinceid` int(11) NOT NULL DEFAULT '0' COMMENT '所属省份id',
  `countryid` int(11) NOT NULL DEFAULT '0' COMMENT '所属国家id',  
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='城市信息';
