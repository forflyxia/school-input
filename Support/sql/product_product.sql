CREATE TABLE `product_product` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '产品主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '产品名称',
  `logo` varchar(200) NOT NULL DEFAULT '' COMMENT '产品logo',
  `categoryid` int(11) NOT NULL DEFAULT '0' COMMENT '所属类别',  
  `introduction` varchar(200) NOT NULL DEFAULT '' COMMENT '简介',  
  `merchantid` int(11) NOT NULL DEFAULT '0' COMMENT '所属商户',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='产品信息';
