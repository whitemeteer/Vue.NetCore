<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/app/cqb_base_step/CQB_BASE_STEP.js此处编写
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
    import extend from "@/extension/app/cqb_base_step/CQB_BASE_STEP.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: 'CQB_BASE_STEP',
                name: 'cqb_base_step/CQB_BASE_STEP',
                url: "/CQB_BASE_STEP/",
                sortName: "ID"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'ID',title:'主键',type:'string',link:true,sort:true,width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ImportVersion',title:'导入版本',type:'string',sort:true,width:180,align:'left',sort:true},
                       {field:'MES_STEP_LIST',title:'MES_STEP_LIST',type:'string',sort:true,width:110,align:'left'},
                       {field:'PROCESS',title:'制程',type:'string',sort:true,width:180,align:'left'},
                       {field:'PKGType',title:'封装类型',type:'string',sort:true,width:110,align:'left'},
                       {field:'PKG_GROUP',title:'PKG_GROUP',type:'string',sort:true,width:110,align:'left'},
                       {field:'PLANT',title:'长别',type:'string',sort:true,width:110,align:'left'},
                       {field:'CUSTOMER',title:'客户代码',type:'string',sort:true,width:110,align:'left'},
                       {field:'WAFER_THICKNESS',title:'WAFER_THICKNESS',type:'string',sort:true,width:110,align:'left'},
                       {field:'IS_GAAS',title:'是否 GaAs?',type:'string',sort:true,width:110,align:'left'},
                       {field:'WAFER_SURFACE_STRUCTURE',title:'WAFER_SURFACE_STRUCTURE',type:'string',sort:true,width:110,align:'left'},
                       {field:'SPE_DIEATTACH_METHOD',title:'特殊作业',type:'string',sort:true,width:110,align:'left'},
                       {field:'DIE_ATTACH',title:'判断作业次数',type:'string',sort:true,width:110,align:'left'},
                       {field:'AUTO_FLAG',title:'AUTO_FLAG',type:'string',sort:true,width:110,align:'left'},
                       {field:'W_MIN_PKGSIZE',title:'W_MIN_PKGSIZE',type:'string',sort:true,width:110,align:'left'},
                       {field:'W_MAX_PKGSIZE',title:'W_MAX_PKGSIZE',type:'string',sort:true,width:110,align:'left'},
                       {field:'SBS_PLIES',title:'SBS层数',type:'string',sort:true,width:110,align:'left'},
                       {field:'PLATING_TYPE',title:'电镀类型',type:'string',sort:true,width:110,align:'left'},
                       {field:'TAPE_SHAPE',title:'LF是否贴膜',type:'string',sort:true,width:110,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',sort:true,width:150,align:'left',sort:true},
                       {field:'CreateUserId',title:'CreateUserId',type:'string',sort:true,width:110,align:'left'},
                       {field:'CreateUserName',title:'CreateUserName',type:'string',sort:true,width:110,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',sort:true,width:150,align:'left',sort:true},
                       {field:'ModifyUserId',title:'ModifyUserId',type:'string',sort:true,width:110,align:'left'},
                       {field:'ModifyUserName',title:'ModifyUserName',type:'string',sort:true,width:110,align:'left'},
                       {field:'Status',title:'Y,N',type:'string',sort:true,width:110,align:'left'},
                       {field:'DeleteMark',title:'Y,N',type:'string',sort:true,width:110,align:'left'},
                       {field:'Reference1',title:'Reference1',type:'string',sort:true,width:110,align:'left'},
                       {field:'Reference2',title:'Reference2',type:'string',sort:true,width:120,align:'left'},
                       {field:'Reference3',title:'Reference3',type:'string',sort:true,width:180,align:'left'},
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
