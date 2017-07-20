CREATE TABLE `config_country` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '国家信息主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '国家名称',
  `ename` varchar(100) NOT NULL DEFAULT '' COMMENT '国家英文名称',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='国家信息';
