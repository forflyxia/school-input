CREATE TABLE `product_product_description` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '产品描述主键',
  `productid` int(11) NOT NULL DEFAULT '0' COMMENT '产品id',  
  `description` varchar(2000) NOT NULL DEFAULT '' COMMENT '商品描述', 
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='产品描述信息';
