<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/app/cqb_base_assystep_itemdetail/CQB_BASE_ASSYSTEP_ItemDetail.js此处编写
 -->
<template>
    <view-grid ref="grid"
               :columns="columns"
               :detail="detail"
               :editFormFields="editFormFields"
               :editFormOptions="editFormOptions"
               :searchFormFields="searchFormFields"
               :searchFormOptions="searchFormOptions"
               :table="table"
               :extend="extend">
    </view-grid>
</template>
<script>
    import extend from "@/extension/app/cqb_base_assystep_itemdetail/CQB_BASE_ASSYSTEP_ItemDetail.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: 'CQB_BASE_ASSYSTEP',
                name: 'cqb_base_assystep_itemdetail/CQB_BASE_ASSYSTEP_ItemDetail',
                url: "/CQB_BASE_ASSYSTEP_ItemDetail/",
                sortName: "STEPNAME"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'ID',title:'主键',type:'string',sort:true,width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ImportVersion',title:'导入版本',type:'string',sort:true,width:220,align:'left',sort:true},
                       {field:'STEPNAME',title:'站点',type:'string',link:true,sort:true,width:220,align:'left'},
                       {field:'IS_MATH',title:'是否计算',type:'string',sort:true,width:110,align:'left'},
                       {field:'IS_OUTSOURCING',title:'是否外包',type:'string',sort:true,width:110,align:'left'},
                       {field:'PROCESS',title:'制程',type:'string',sort:true,width:220,align:'left'},
                       {field:'WAFER_SIZE',title:'晶圆尺寸',type:'string',sort:true,width:120,align:'left'},
                       {field:'PLANT',title:'厂别',type:'string',sort:true,width:120,align:'left'},
                       {field:'CUSTOMER',title:'客户代码',type:'string',sort:true,width:120,align:'left'},
                       {field:'AUTOFLAG',title:'AUTOFLAG',type:'string',sort:true,width:120,align:'left'},
                       {field:'PKG_GROUP',title:'封装体分组',type:'string',sort:true,width:120,align:'left'},
                       {field:'SBS_PLIES',title:'SBS层数',type:'string',sort:true,width:120,align:'left'},
                       {field:'LF_LO',title:'LF_LO',type:'string',sort:true,width:120,align:'left'},
                       {field:'PLATING_TYPE',title:'电镀类型',type:'string',sort:true,width:120,align:'left'},
                       {field:'WIRE_TYPE',title:'金线类型',type:'string',sort:true,width:120,align:'left'},
                       {field:'SPE_DIEATTACH_METHOD',title:'特殊作业',type:'string',sort:true,width:120,align:'left'},
                       {field:'W_MIN_PKGSIZE',title:'W_MIN_PKGSIZE',type:'string',sort:true,width:120,align:'left'},
                       {field:'W_MAX_PKGSIZE',title:'W_MAX_PKGSIZE',type:'string',sort:true,width:120,align:'left'},
                       {field:'W_MIN_DIESIZE',title:'W_MIN_DIESIZE',type:'string',sort:true,width:120,align:'left'},
                       {field:'W_MAX_DIESIZE',title:'W_MAX_DIESIZE',type:'string',sort:true,width:120,align:'left'},
                       {field:'L_MIN_DIESIZE',title:'L_MIN_DIESIZE',type:'string',sort:true,width:120,align:'left'},
                       {field:'L_MAX_DIESIZE',title:'L_MAX_DIESIZE',type:'string',sort:true,width:120,align:'left'},
                       {field:'IS_WARM',title:'是否加热',type:'string',sort:true,width:120,align:'left'},
                       {field:'MATERIAL_TYPE',title:'MATERIAL_TYPE',type:'string',sort:true,width:120,align:'left'},
                       {field:'STRIP_SIZE_Y',title:'STRIP_SIZE_Y',type:'string',sort:true,width:120,align:'left'},
                       {field:'M_ID',title:'设备型号',type:'string',sort:true,width:120,align:'left'},
                       {field:'M_WARM_COUNT',title:'烤箱箱体数量',type:'string',sort:true,width:120,align:'left'},
                       {field:'M_MMR',title:'MMR',type:'string',sort:true,width:120,align:'left'},
                       {field:'M_RQD',title:'RQD',type:'string',sort:true,width:120,align:'left'},
                       {field:'M_COEE',title:'COEE',type:'string',sort:true,width:120,align:'left'},
                       {field:'M_PRICE',title:'PRICE',type:'decimal',sort:true,width:110,align:'left'},
                       {field:'M_CONSIGN',title:'CONSIGN',type:'string',sort:true,width:120,align:'left'},
                       {field:'AMT_ID',title:'辅助设备+Tooling',type:'string',sort:true,width:120,align:'left'},
                       {field:'AMT_PRICE',title:'辅助设备+Tooling价格',type:'string',sort:true,width:120,align:'left'},
                       {field:'AMT_CONSIGN',title:'辅助设备+Tooling委托',type:'string',sort:true,width:120,align:'left'},
                       {field:'MOLD_CHASE_PRICE',title:'铸模槽价格',type:'string',sort:true,width:120,align:'left'},
                       {field:'MOLD_CHASE_CONSIGN',title:'铸模槽委托',type:'string',sort:true,width:120,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',sort:true,width:150,align:'left',sort:true},
                       {field:'CreateUserId',title:'CreateUserId',type:'string',sort:true,width:110,align:'left'},
                       {field:'CreateUserName',title:'CreateUserName',type:'string',sort:true,width:120,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',sort:true,width:150,align:'left',sort:true},
                       {field:'ModifyUserId',title:'ModifyUserId',type:'string',sort:true,width:110,align:'left'},
                       {field:'ModifyUserName',title:'ModifyUserName',type:'string',sort:true,width:120,align:'left'},
                       {field:'Status',title:'Y,N',type:'string',sort:true,width:110,align:'left'},
                       {field:'DeleteMark',title:'Y,N',type:'string',sort:true,width:110,align:'left'},
                       {field:'Reference1',title:'Reference1',type:'string',sort:true,width:110,align:'left'},
                       {field:'Reference2',title:'Reference2',type:'string',sort:true,width:120,align:'left'},
                       {field:'Reference3',title:'Reference3',type:'string',sort:true,width:110,align:'left'},
                       {field:'Reference4',title:'Reference4',type:'string',sort:true,width:220,align:'left'},
                       {field:'Reference5',title:'Reference5',type:'string',sort:true,width:110,align:'left'}]);
            const detail = ref({
                cnName: "#detailCnName",
                table: "#detailTable",
                columns: [],
                sortName: "",
                key: ""
            });
            return {
                table,
                extend,
                editFormFields,
                editFormOptions,
                searchFormFields,
                searchFormOptions,
                columns,
                detail,
            };
        },
    });
</script>
