CREATE TABLE `config_province` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '省份信息主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '省份名称',
  `ename` varchar(100) NOT NULL DEFAULT '' COMMENT '省份英文名称',
  `countryid` int(11) NOT NULL DEFAULT '0' COMMENT '所属国家id',   
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='省份信息';
