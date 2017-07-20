CREATE TABLE `order_order_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '订单详情id主键',
  `orderid` int(11) NOT NULL DEFAULT '0' COMMENT '订单id',
  `productid` int(11) NOT NULL DEFAULT '0' COMMENT '商品id',  
  `unitprice` DECIMAL(14,2) NOT NULL DEFAULT '0.0' COMMENT '单价',
  `quantity` int(11) NOT NULL DEFAULT '0' COMMENT '购买数量',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '订单状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='订单详情信息';
