CREATE TABLE `product_product_price` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '产品价格主键',
  `productid` int(11) NOT NULL DEFAULT '0' COMMENT '产品id',  
  `unitprice` DECIMAL(14,2) NOT NULL DEFAULT '0.0' COMMENT '单价',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='产品价格信息';