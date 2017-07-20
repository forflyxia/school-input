CREATE TABLE `product_product_category` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '产品类别信息主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '产品名称',
  `parentcategoryid` int(11) NOT NULL DEFAULT '0' COMMENT '所属父类',   
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='产品类别信息';
