CREATE TABLE `merchant_merchant` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '主键',
  `name` varchar(100) NOT NULL DEFAULT '' COMMENT '商户名称',
  `shortname` varchar(45) NOT NULL DEFAULT '' COMMENT '商户短名称',
  `branch` varchar(45) NOT NULL DEFAULT '' COMMENT '商户分店',
  `logo` varchar(200) NOT NULL DEFAULT '' COMMENT '商户logo',
  `introduction` varchar(200) NOT NULL DEFAULT '' COMMENT '简介',
  `contact` varchar(45) NOT NULL DEFAULT '' COMMENT '联系人',
  `telphone` varchar(45) NOT NULL DEFAULT '' COMMENT '电话',
  `mobliephone` varchar(45) NOT NULL DEFAULT '' COMMENT '手机',  
  `businesslicence` varchar(45) NOT NULL DEFAULT '' COMMENT '营业执照',
  `legalperson` varchar(45) NOT NULL DEFAULT '' COMMENT '法人',  
  `cityid` int(11) NOT NULL DEFAULT '0' COMMENT '所属城市',  
  `address` varchar(100) NOT NULL DEFAULT '' COMMENT '地址',
  `longitude` DECIMAL(14,6) NOT NULL DEFAULT '0.0' COMMENT '经度',
  `latitude` DECIMAL(14,6) NOT NULL DEFAULT '0.0' COMMENT '纬度',
  `status` int(2) NOT NULL DEFAULT '0' COMMENT '状态',
  `createtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatetime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='商户信息';
