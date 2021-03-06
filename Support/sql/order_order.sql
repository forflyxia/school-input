CREATE TABLE `order_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '订单信息id主键',
  `userid` int(11) NOT NULL DEFAULT '0' COMMENT '用户id',
  `contact` varchar(45) NOT NULL DEFAULT '' COMMENT '联系人',
  `telphone` varchar(45) NOT NULL DEFAULT '' COMMENT '电话',
  `mobliephone` varchar(45) NOT NULL DEFAULT '' COMMENT '手机',  
  `totalamount` DECIMAL(14,2) NOT NULL DEFAULT '0.0' COMMENT '总金额',
  `reduction` DECIMAL(14,2) NOT NULL DEFAULT '0.0' COMMENT '减免金额',
  `amountpaid` DECIMAL(14,2) NOT NULL DEFAULT '0.0' COMMENT '实收金额',  
  `couponcode` varchar(100) NOT NULL DEFAULT '' COMMENT '优惠券merchant_merchant',
  `deliverycityid` int(11) NOT NULL DEFAULT '0' COMMENT '配送城市',  
  `deliveryschoolid` int(11) NOT NULL DEFAULT '0' COMMENT '配送学校id', 
  `deliveryschoolbranchid` int(11) NOT NULL DEFAULT '0' COMMENT '配送分校id', 
  `deliveryaddress` varchar(100) NOT NULL DEFAULT '' COMMENT '配送地址',
  `remark` varchar(2000) NOT NULL DEFAULT '' COMMENT '备注',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '订单状态',  
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='订单信息';
